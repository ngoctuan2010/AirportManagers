﻿using DevExpress.XtraEditors;
using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        Employee employee = new Employee();
        Account account = new Account();
        BUS_Employee busEmp = new BUS_Employee();
        BUS_Account busAcc = new BUS_Account();
        DAL_Account dalAccount = new DAL_Account();
        DAL_Employee dalEmployee = new DAL_Employee();
        public Main()
        {
            InitializeComponent();
        }

        void LoadDataGridViewEmployee()
        {
            using (AirportManager db = new AirportManager())
            {
                dgvEmployee.DataSource = db.Employees.ToList<Employee>();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }
        // Customer Controller
        private void tpCustomer_Paint(object sender, PaintEventArgs e)
        {
            gcCustomer.DataSource = bCustomer.getCustomerList();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Text != null && !txtCustomerID.Text.IsEmptyOrSingle()
               && txtCustomerPhone.Text != null && !txtCustomerPhone.Text.IsEmptyOrSingle()
               && txtCustomerName.Text != null && !txtCustomerName.Text.IsEmptyOrSingle()
               && txtCustomerEmail.Text != null && !txtCustomerEmail.Text.IsEmptyOrSingle()
               && txtCustomerNationality.Text != null && !txtCustomerNationality.Text.IsEmptyOrSingle()
               && txtCustomerAddress.Text != null && !txtCustomerAddress.Text.IsEmptyOrSingle()
               && dtpCustomerDate.Text != null && (rbCustomerMale.Checked == true || rbCustomerFemale.Checked == true))
            {
                string customerID = txtCustomerID.Text.Trim();
                string customerName = txtCustomerName.Text.Trim();
                string customerEmail = txtCustomerEmail.Text.Trim();
                string customerAddress = txtCustomerAddress.Text.Trim();
                string customerPhone = txtCustomerPhone.Text.Trim();
                String customerDate = dtpCustomerDate.Value.ToString("dd/MM/yyyy");
                string customerNationality = txtCustomerNationality.Text.Trim();
                bool? customerSex;
                if (rbCustomerFemale.Checked)
                {
                    customerSex = true;
                }
                else
                {
                    customerSex = false;
                }

                Customer customer = new Customer();
                customer.NationalID = customerID;
                customer.Name = customerName;
                customer.Email = customerEmail;
                customer.Address = customerAddress;
                customer.TeleNumber = customerPhone;
                customer.DateOfBirth = DateTime.ParseExact(customerDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                customer.Nationality = customerNationality;
                customer.Sex = customerSex;

                try
                {
                    if (bCustomer.addCustomer(customer))
                    {
                        MessageBox.Show("Add customer successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        gcCustomer.DataSource = bCustomer.getCustomerList();
                    }
                    else
                    {
                        MessageBox.Show("Add customer failure", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Not enough infomation about customer", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gvCustomer_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

            if (e.Clicks == 2) //Send customer to ticket tab
            {
                tabControls.SelectedPageIndex = 0;
                Customer order_customer = (Customer)gvCustomer.GetRow(gvCustomer.FocusedRowHandle);
                lbTicketsCustomerID.Text = order_customer.CustomerID.ToString();
                lbTicketCustomerName.Text = order_customer.Name;
                lbTicketCustomerAddress.Text = order_customer.Address;
                lbTicketCustomerPhone.Text = order_customer.TeleNumber;
                lbTicketCustomerNid.Text = order_customer.NationalID;
                if (order_customer.Sex == true)
                {
                    lbTicketCustomerSex.Text = "Nữ";
                }
                else
                {
                    lbTicketCustomerSex.Text = "Nam";
                }
                lbTicketCustomerDoB.Text = order_customer.DateOfBirth.Value.ToString("dd/MM/yyyy");
            }
            else if (e.Clicks == 1) //fetch data to textfield
            {

                if (gvCustomer.GetRow(gvCustomer.FocusedRowHandle) != null)
                {
                    Customer cur_customer = (Customer)gvCustomer.GetRow(gvCustomer.FocusedRowHandle);
                    txtCustomerID.Text = cur_customer.NationalID;
                    txtCustomerName.Text = cur_customer.Name;
                    txtCustomerAddress.Text = cur_customer.Address;
                    txtCustomerPhone.Text = cur_customer.TeleNumber;
                    txtCustomerEmail.Text = cur_customer.Email;
                    txtCustomerNationality.Text = cur_customer.Nationality;
                    dtpCustomerDate.Value = cur_customer.DateOfBirth.Value;
                    if (cur_customer.Sex == true)
                    {
                        rbCustomerFemale.Checked = true;
                    }
                    else
                    {
                        rbCustomerMale.Checked = true;
                    }
                }

            }
        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            if (gvCustomer.GetRow(gvCustomer.FocusedRowHandle) != null)
            {
                if (txtCustomerID.Text != null && !txtCustomerID.Text.IsEmptyOrSingle()
               && txtCustomerPhone.Text != null && !txtCustomerPhone.Text.IsEmptyOrSingle()
               && txtCustomerName.Text != null && !txtCustomerName.Text.IsEmptyOrSingle()
               && txtCustomerEmail.Text != null && !txtCustomerEmail.Text.IsEmptyOrSingle()
               && txtCustomerNationality.Text != null && !txtCustomerNationality.Text.IsEmptyOrSingle()
               && txtCustomerAddress.Text != null && !txtCustomerAddress.Text.IsEmptyOrSingle()
               && dtpCustomerDate.Text != null && (rbCustomerMale.Checked == true || rbCustomerFemale.Checked == true))
                {
                    Customer current_customer = (Customer)gvCustomer.GetRow(gvCustomer.FocusedRowHandle);
                    Customer updated_customer = new Customer();
                    updated_customer.CustomerID = current_customer.CustomerID;
                    updated_customer.Name = txtCustomerName.Text.Trim();
                    updated_customer.NationalID = txtCustomerID.Text.Trim();
                    updated_customer.Email = txtCustomerEmail.Text.Trim();
                    updated_customer.Address = txtCustomerAddress.Text.Trim();
                    updated_customer.TeleNumber = txtCustomerPhone.Text.Trim();
                    updated_customer.DateOfBirth = DateTime.ParseExact(dtpCustomerDate.Value.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    updated_customer.Nationality = txtCustomerNationality.Text.Trim();
                    if (rbCustomerFemale.Checked)
                    {
                        updated_customer.Sex = true;
                    }
                    else
                    {
                        updated_customer.Sex = false;
                    }
                    try
                    {
                        if (bCustomer.updateCustomer(updated_customer))
                        {
                            MessageBox.Show("Update customer successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            gcCustomer.DataSource = bCustomer.getCustomerList();
                        }
                        else
                        {
                            MessageBox.Show("Update customer failure", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }

            }
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this customer?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (gvCustomer.GetRow(gvCustomer.FocusedRowHandle) != null)
                {
                    Customer current_customer = (Customer)gvCustomer.GetRow(gvCustomer.FocusedRowHandle);
                    int id = current_customer.CustomerID;

                    if (bCustomer.deleteCustomer(id))
                    {
                        MessageBox.Show("Delete customer successfully", "Success");
                        gcCustomer.DataSource = bCustomer.getCustomerList();
                    }
                    else
                    {
                        MessageBox.Show("Delete customer failure", "Error");
                    }
                }
            }

        }

        //Ticket Controller
        private void tpTicket_Paint(object sender, PaintEventArgs e)
        {
            gcTicket.DataSource = bTicket.getTicketsList();
        }

        private void gvTicket_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gvTicket.GetRow(gvTicket.FocusedRowHandle) != null)
            {
                Bill_Detail ticket = (Bill_Detail)gvTicket.GetRow(gvTicket.FocusedRowHandle);
                Customer customer = ticket.Customer;
                MessageBox.Show(customer.Name);
            }
        }

        private void ButtonAddPlaneClick(object sender, EventArgs e)
        {
            if (txtPlaneModel.Text != null && !txtPlaneModel.Text.IsEmptyOrSingle()
                                           && txtManufactor.Text != null && !txtManufactor.Text.IsEmptyOrSingle()
                                           && txtPlaneSeat.Text != null && !txtPlaneSeat.Text.IsEmptyOrSingle()
                                           && txtRegistration.Text != null && !txtRegistration.Text.IsEmptyOrSingle()
                                           && comboBoxPlaneState != null)
            {
                var obj = new Plane
                {
                    Model = txtPlaneModel.Text.Trim(),
                    Manufacturer = txtManufactor.Text.Trim(),
                    Registration = txtRegistration.Text.Trim(),
                    TotalSeat = int.Parse(txtPlaneSeat.Text.Trim()),
                    State = comboBoxPlaneState.SelectedIndex
                };
                try
                {
                    if (planebus.AddPlane(obj))
                    {
                        MessageBox.Show(@"Add plane successful!!!", @"SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        gcCustomer.DataSource = bCustomer.getCustomerList();
                    }
                    else
                    {
                        MessageBox.Show(@"Add plane failed!!!", @"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, @"WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show(@"Missing plane data!!!", @"WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void ButtonUpdatePlaneClick(object sender, EventArgs e)
        {
            if (gridPlane.GetRow(gridPlane.FocusedRowHandle) != null)
            {
                if (txtPlaneModel.Text != null && !txtPlaneModel.Text.IsEmptyOrSingle()
                                               && txtManufactor.Text != null && !txtManufactor.Text.IsEmptyOrSingle()
                                               && txtPlaneSeat.Text != null && !txtPlaneSeat.Text.IsEmptyOrSingle()
                                               && txtRegistration.Text != null && !txtRegistration.Text.IsEmptyOrSingle()
                                               && comboBoxPlaneState != null)
                {
                    Plane pickedPlane = (Plane)gridPlane.GetRow(gridPlane.FocusedRowHandle);
                    Plane updatePlane = new Plane();
                    updatePlane.PlaneID = pickedPlane.PlaneID;
                    updatePlane.Model = txtPlaneModel.Text.Trim();
                    updatePlane.Manufacturer = txtManufactor.Text.Trim();
                    updatePlane.TotalSeat = int.Parse(txtPlaneSeat.Text.Trim());
                    updatePlane.Registration = txtRegistration.Text.Trim();
                    updatePlane.State = comboBoxPlaneState.SelectedIndex;
                    try
                    {
                        if (planebus.UpdatePlane(updatePlane))
                        {
                            MessageBox.Show(@"Update plane successful", @"SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            gcCustomer.DataSource = bCustomer.getCustomerList();
                        }
                        else
                        {
                            MessageBox.Show(@"Update plane failed", @"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, @"WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(@"Missing plane data!!!", @"WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(@"Missing plane data!!!", @"WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonDeletePlaneClick(object sender, EventArgs e)
        {
            if (txtPlaneModel.Text != null && !txtPlaneModel.Text.IsEmptyOrSingle()
                                           && txtManufactor.Text != null && !txtManufactor.Text.IsEmptyOrSingle()
                                           && txtPlaneSeat.Text != null && !txtPlaneSeat.Text.IsEmptyOrSingle()
                                           && txtRegistration.Text != null && !txtRegistration.Text.IsEmptyOrSingle()
                                           && comboBoxPlaneState != null)
            {
                var pickedPlane = (Plane)gridPlane.GetRow(gridPlane.FocusedRowHandle);
                try
                {
                    if (planebus.RemovePlane(pickedPlane))
                    {
                        MessageBox.Show(@"Remove plane successful", @"SUCCESS", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        gcCustomer.DataSource = bCustomer.getCustomerList();
                    }
                    else
                    {
                        MessageBox.Show(@"Remove plane failed", @"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, @"WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //<=========

        //FlightController  =========>

        private void GridControlFlightLoad(object sender, EventArgs e)
        {
            comboBoxDepart.DataSource = flightbus.GetLocations();
            comboBoxDesti.DataSource = flightbus.GetLocations();
            comboBoxDepart.DisplayMember = comboBoxDesti.DisplayMember = "LocationName";
            comboBoxPlane.DataSource = planebus.GetListPlanes();
            comboBoxPlane.DisplayMember = "Registration";
        }

        private void gridViewFlight_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gridViewFlight.GetRow(gridViewFlight.FocusedRowHandle) == null) return;
            var pickedFlight = (Flight)gridViewFlight.GetRow(gridViewFlight.FocusedRowHandle);
            var planeID = (Plane)comboBoxPlane.SelectedItem;
            var loDes = (Location)comboBoxDepart.SelectedItem;
            var loDep = (Location)comboBoxDesti.SelectedItem;
            textFlightID.Text = pickedFlight.FlightID.ToString();
            planeID.PlaneID = pickedFlight.PlaneID;
            textAirline.Text = pickedFlight.Airline;
            loDes.LocationID = (int)pickedFlight.Departure;
            loDep.LocationID = (int)pickedFlight.Destination;
            dateDepartPicker.Value = pickedFlight.DateOfDeparture.Date;
            timeDepartPicker.Value = DateTime.Parse(pickedFlight.DateOfDeparture.TimeOfDay.ToString());
        }

        private void buttonAddFlight_Click(object sender, EventArgs e)
        {
            if (textAirline.Text != null && !textAirline.Text.IsEmptyOrSingle()
                                           && comboBoxDepart.SelectedItem != comboBoxDesti.SelectedItem)
            {
                var daTime = dateDepartPicker.Value.ToString("yyyy/MM/dd") + " " + timeDepartPicker.Value.ToString("HH:mm:ss");
                var planeFl = (Plane)comboBoxPlane.SelectedItem;
                var loDes = (Location)comboBoxDepart.SelectedItem;
                var loDep = (Location)comboBoxDesti.SelectedItem;
                var obj = new Flight()
                {
                    PlaneID = planeFl.PlaneID,
                    Airline = textAirline.Text.Trim(),
                    Departure = loDep.LocationID,
                    Destination = loDes.LocationID,
                    DateOfDeparture = DateTime.Parse(daTime)
                };
                try
                {
                    if (flightbus.AddFlights(obj))
                {
                    MessageBox.Show(@"Add flight successful!!!", @"SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gcCustomer.DataSource = bCustomer.getCustomerList();
                }
                else
                {
                    MessageBox.Show(@"Add flight failed!!!", @"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                catch (Exception ex)
                {
                MessageBox.Show(ex.Message, @"WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
            else
            {
                MessageBox.Show(@"Missing flight data!!!", @"WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonUpdateFlight_Click(object sender, EventArgs e)
        {
            if (gridViewFlight.GetRow(gridViewFlight.FocusedRowHandle) != null)
            {
                if (textAirline.Text != null && !textAirline.Text.IsEmptyOrSingle()
                                                && comboBoxDepart.SelectedItem != comboBoxDesti.SelectedItem)
                {
                    Flight pickedFlight = (Flight)gridViewFlight.GetRow(gridViewFlight.FocusedRowHandle);
                    Flight updatedFlight = new Flight();
                    var daTime = dateDepartPicker.Value.ToString("yyyy/MM/dd") + " " + timeDepartPicker.Value.ToString("HH:mm:ss");
                    var planeFl = (Plane)comboBoxDepart.SelectedItem;
                    var loDes = (Location)comboBoxDepart.SelectedItem;
                    var loDep = (Location)comboBoxDesti.SelectedItem;
                    updatedFlight.FlightID = pickedFlight.FlightID;
                    updatedFlight.PlaneID = planeFl.PlaneID;
                    updatedFlight.Airline = textAirline.Text.Trim();
                    updatedFlight.Departure = loDep.LocationID;
                    updatedFlight.Destination = loDes.LocationID;
                    updatedFlight.DateOfDeparture = DateTime.Parse(daTime);
                    try
                    {
                        if (flightbus.UpdateFlights(updatedFlight))
                        {
                            MessageBox.Show(@"Update flight successful", @"SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            gcCustomer.DataSource = bCustomer.getCustomerList();
                        }
                        else
                        {
                            MessageBox.Show(@"Update flight failed", @"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, @"WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(@"Missing flight data!!!", @"WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(@"Missing flight data!!!", @"WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDeleteFlight_Click(object sender, EventArgs e)
        {
            var pickedFlight = (Flight)gridViewFlight.GetRow(gridViewFlight.FocusedRowHandle);
            try
            {
                if (flightbus.DeleteFlights(pickedFlight))
                {
                    MessageBox.Show(@"Remove flight successful", @"SUCCESS", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    gcCustomer.DataSource = bCustomer.getCustomerList();
                }
                else
                {
                    MessageBox.Show(@"Remove flight failed", @"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TabNavigationFlightPaint(object sender, PaintEventArgs e)
        {
            gridControlFlight.DataSource = flightbus.GetListFlights();
        }
    }
}