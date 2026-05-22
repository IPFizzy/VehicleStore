/*
 * Keon Bushman
 * CST - 250
 * 05/24/2026
 * Vehicle Class Library
 * Activity 1
 * Activity 1 Guide
 */

namespace VehicleStoreGUIApp
{
    public partial class FrmVehicleStore : Form
    {
        // Class level variables
        string currentVehicleType;

        /// <summary>
        /// Default constructor FrmVehicleStore
        /// </summary>
        public FrmVehicleStore()
        {
            InitializeComponent();
            // Initialize the current vehicle to create
            currentVehicleType = "";
        }

        /// <summary>
        /// Click event handler to create a car
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RdoCarClickEH(object sender, EventArgs e)
        {
            // Update the selected vehicle variable
            currentVehicleType = "Car";

            // Change the label for the specialty boolean
            lblSpecialtyBoolean.Text = "Is the car a convertible?";
            // Change the label for the specialty decimal
            lblSpecialtyDecimal.Text = "Trunk Size (cubic feet):";

            // Show the specialty boolean label and radio buttons
            lblSpecialtyBoolean.Visible = true;
            rdoSpecialtyYes.Visible = true;
            rdoSpecialtyNo.Visible = true;
            // Show the specialty decimal label and text box
            lblSpecialtyDecimal.Visible = true;
            txtSpecialtyDecimal.Visible = true;
        }
    }
}
