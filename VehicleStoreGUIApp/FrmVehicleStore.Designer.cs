namespace VehicleStoreGUIApp
{
    partial class FrmVehicleStore
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbxCreateVehicle = new GroupBox();
            lblWheelsError = new Label();
            lblYearError = new Label();
            lblPriceError = new Label();
            lblModelError = new Label();
            lblMakeError = new Label();
            lblVehicleTypeError = new Label();
            btnCreate = new Button();
            txtWheels = new TextBox();
            txtPrice = new TextBox();
            txtYear = new TextBox();
            txtModel = new TextBox();
            lblWheels = new Label();
            lblPrice = new Label();
            rdoVehicle = new RadioButton();
            rdoMotercycle = new RadioButton();
            txtMake = new TextBox();
            lblYear = new Label();
            rdoPickup = new RadioButton();
            lblModel = new Label();
            rdoCar = new RadioButton();
            lblMake = new Label();
            gbxSpecialtyProperties = new GroupBox();
            txtSpecialtyDecimal = new TextBox();
            rdoSpecialtyNo = new RadioButton();
            lblSpecialtyDecimalError = new Label();
            lblSpecialtyBooleanError = new Label();
            lblSpecialtyDecimal = new Label();
            rdoSpecialtyYes = new RadioButton();
            lblSpecialtyBoolean = new Label();
            gbxStoreInventory = new GroupBox();
            lstInventory = new ListBox();
            btnAddCart = new Button();
            gbxShoppingCart = new GroupBox();
            lstShoppingCart = new ListBox();
            btnCheckout = new Button();
            lblTotal = new Label();
            lblTotalAmount = new Label();
            gbxCreateVehicle.SuspendLayout();
            gbxSpecialtyProperties.SuspendLayout();
            gbxStoreInventory.SuspendLayout();
            gbxShoppingCart.SuspendLayout();
            SuspendLayout();
            // 
            // gbxCreateVehicle
            // 
            gbxCreateVehicle.Controls.Add(lblWheelsError);
            gbxCreateVehicle.Controls.Add(lblYearError);
            gbxCreateVehicle.Controls.Add(lblPriceError);
            gbxCreateVehicle.Controls.Add(lblModelError);
            gbxCreateVehicle.Controls.Add(lblMakeError);
            gbxCreateVehicle.Controls.Add(lblVehicleTypeError);
            gbxCreateVehicle.Controls.Add(btnCreate);
            gbxCreateVehicle.Controls.Add(txtWheels);
            gbxCreateVehicle.Controls.Add(txtPrice);
            gbxCreateVehicle.Controls.Add(txtYear);
            gbxCreateVehicle.Controls.Add(txtModel);
            gbxCreateVehicle.Controls.Add(lblWheels);
            gbxCreateVehicle.Controls.Add(lblPrice);
            gbxCreateVehicle.Controls.Add(rdoVehicle);
            gbxCreateVehicle.Controls.Add(rdoMotercycle);
            gbxCreateVehicle.Controls.Add(txtMake);
            gbxCreateVehicle.Controls.Add(lblYear);
            gbxCreateVehicle.Controls.Add(rdoPickup);
            gbxCreateVehicle.Controls.Add(lblModel);
            gbxCreateVehicle.Controls.Add(rdoCar);
            gbxCreateVehicle.Controls.Add(lblMake);
            gbxCreateVehicle.Location = new Point(12, 12);
            gbxCreateVehicle.Name = "gbxCreateVehicle";
            gbxCreateVehicle.Size = new Size(232, 368);
            gbxCreateVehicle.TabIndex = 0;
            gbxCreateVehicle.TabStop = false;
            gbxCreateVehicle.Text = "Create a Vehicle";
            // 
            // lblWheelsError
            // 
            lblWheelsError.AutoSize = true;
            lblWheelsError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWheelsError.ForeColor = Color.Red;
            lblWheelsError.Location = new Point(40, 320);
            lblWheelsError.Name = "lblWheelsError";
            lblWheelsError.Size = new Size(186, 15);
            lblWheelsError.TabIndex = 13;
            lblWheelsError.Text = "Please enter a valid wheel count";
            // 
            // lblYearError
            // 
            lblYearError.AutoSize = true;
            lblYearError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblYearError.ForeColor = Color.Red;
            lblYearError.Location = new Point(90, 214);
            lblYearError.Name = "lblYearError";
            lblYearError.Size = new Size(141, 15);
            lblYearError.TabIndex = 14;
            lblYearError.Text = "Please enter a valid year";
            // 
            // lblPriceError
            // 
            lblPriceError.AutoSize = true;
            lblPriceError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPriceError.ForeColor = Color.Red;
            lblPriceError.Location = new Point(90, 264);
            lblPriceError.Name = "lblPriceError";
            lblPriceError.Size = new Size(145, 15);
            lblPriceError.TabIndex = 13;
            lblPriceError.Text = "Please enter a valid price";
            // 
            // lblModelError
            // 
            lblModelError.AutoSize = true;
            lblModelError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModelError.ForeColor = Color.Red;
            lblModelError.Location = new Point(90, 162);
            lblModelError.Name = "lblModelError";
            lblModelError.Size = new Size(123, 15);
            lblModelError.TabIndex = 10;
            lblModelError.Text = "Please enter a model";
            // 
            // lblMakeError
            // 
            lblMakeError.AutoSize = true;
            lblMakeError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMakeError.ForeColor = Color.Red;
            lblMakeError.Location = new Point(90, 112);
            lblMakeError.Name = "lblMakeError";
            lblMakeError.Size = new Size(119, 15);
            lblMakeError.TabIndex = 9;
            lblMakeError.Text = "Please enter a make";
            // 
            // lblVehicleTypeError
            // 
            lblVehicleTypeError.AutoSize = true;
            lblVehicleTypeError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVehicleTypeError.ForeColor = Color.Red;
            lblVehicleTypeError.Location = new Point(6, 69);
            lblVehicleTypeError.Name = "lblVehicleTypeError";
            lblVehicleTypeError.Size = new Size(166, 15);
            lblVehicleTypeError.TabIndex = 8;
            lblVehicleTypeError.Text = "Please Choose a Vehicle Type";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(71, 339);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // txtWheels
            // 
            txtWheels.Location = new Point(90, 294);
            txtWheels.Name = "txtWheels";
            txtWheels.Size = new Size(125, 23);
            txtWheels.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(90, 238);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 23);
            txtPrice.TabIndex = 3;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(90, 188);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(125, 23);
            txtYear.TabIndex = 4;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(90, 136);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(125, 23);
            txtModel.TabIndex = 5;
            // 
            // lblWheels
            // 
            lblWheels.AutoSize = true;
            lblWheels.Location = new Point(6, 302);
            lblWheels.Name = "lblWheels";
            lblWheels.Size = new Size(48, 15);
            lblWheels.TabIndex = 4;
            lblWheels.Text = "Wheels:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(6, 246);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(36, 15);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Price:";
            // 
            // rdoVehicle
            // 
            rdoVehicle.AutoSize = true;
            rdoVehicle.Location = new Point(106, 47);
            rdoVehicle.Name = "rdoVehicle";
            rdoVehicle.Size = new Size(62, 19);
            rdoVehicle.TabIndex = 3;
            rdoVehicle.TabStop = true;
            rdoVehicle.Text = "Vehicle";
            rdoVehicle.UseVisualStyleBackColor = true;
            // 
            // rdoMotercycle
            // 
            rdoMotercycle.AutoSize = true;
            rdoMotercycle.Location = new Point(106, 22);
            rdoMotercycle.Name = "rdoMotercycle";
            rdoMotercycle.Size = new Size(84, 19);
            rdoMotercycle.TabIndex = 4;
            rdoMotercycle.TabStop = true;
            rdoMotercycle.Text = "Motercycle";
            rdoMotercycle.UseVisualStyleBackColor = true;
            // 
            // txtMake
            // 
            txtMake.Location = new Point(90, 86);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(125, 23);
            txtMake.TabIndex = 1;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(6, 191);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(32, 15);
            lblYear.TabIndex = 3;
            lblYear.Text = "Year:";
            // 
            // rdoPickup
            // 
            rdoPickup.AutoSize = true;
            rdoPickup.Location = new Point(6, 47);
            rdoPickup.Name = "rdoPickup";
            rdoPickup.Size = new Size(61, 19);
            rdoPickup.TabIndex = 2;
            rdoPickup.TabStop = true;
            rdoPickup.Text = "Pickup";
            rdoPickup.UseVisualStyleBackColor = true;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(6, 139);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(44, 15);
            lblModel.TabIndex = 2;
            lblModel.Text = "Model:";
            // 
            // rdoCar
            // 
            rdoCar.AutoSize = true;
            rdoCar.Location = new Point(6, 22);
            rdoCar.Name = "rdoCar";
            rdoCar.Size = new Size(43, 19);
            rdoCar.TabIndex = 1;
            rdoCar.TabStop = true;
            rdoCar.Text = "Car";
            rdoCar.UseVisualStyleBackColor = true;
            rdoCar.Click += RdoCarClickEH;
            // 
            // lblMake
            // 
            lblMake.AutoSize = true;
            lblMake.Location = new Point(6, 94);
            lblMake.Name = "lblMake";
            lblMake.Size = new Size(39, 15);
            lblMake.TabIndex = 1;
            lblMake.Text = "Make:";
            // 
            // gbxSpecialtyProperties
            // 
            gbxSpecialtyProperties.Controls.Add(txtSpecialtyDecimal);
            gbxSpecialtyProperties.Controls.Add(rdoSpecialtyNo);
            gbxSpecialtyProperties.Controls.Add(lblSpecialtyDecimalError);
            gbxSpecialtyProperties.Controls.Add(lblSpecialtyBooleanError);
            gbxSpecialtyProperties.Controls.Add(lblSpecialtyDecimal);
            gbxSpecialtyProperties.Controls.Add(rdoSpecialtyYes);
            gbxSpecialtyProperties.Controls.Add(lblSpecialtyBoolean);
            gbxSpecialtyProperties.Location = new Point(12, 386);
            gbxSpecialtyProperties.Name = "gbxSpecialtyProperties";
            gbxSpecialtyProperties.Size = new Size(232, 159);
            gbxSpecialtyProperties.TabIndex = 1;
            gbxSpecialtyProperties.TabStop = false;
            gbxSpecialtyProperties.Text = "Specialty Properties";
            // 
            // txtSpecialtyDecimal
            // 
            txtSpecialtyDecimal.Location = new Point(115, 105);
            txtSpecialtyDecimal.Name = "txtSpecialtyDecimal";
            txtSpecialtyDecimal.Size = new Size(100, 23);
            txtSpecialtyDecimal.TabIndex = 2;
            // 
            // rdoSpecialtyNo
            // 
            rdoSpecialtyNo.AutoSize = true;
            rdoSpecialtyNo.Location = new Point(80, 55);
            rdoSpecialtyNo.Name = "rdoSpecialtyNo";
            rdoSpecialtyNo.Size = new Size(41, 19);
            rdoSpecialtyNo.TabIndex = 3;
            rdoSpecialtyNo.TabStop = true;
            rdoSpecialtyNo.Text = "No";
            rdoSpecialtyNo.UseVisualStyleBackColor = true;
            // 
            // lblSpecialtyDecimalError
            // 
            lblSpecialtyDecimalError.AutoSize = true;
            lblSpecialtyDecimalError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSpecialtyDecimalError.ForeColor = Color.Red;
            lblSpecialtyDecimalError.Location = new Point(24, 131);
            lblSpecialtyDecimalError.Name = "lblSpecialtyDecimalError";
            lblSpecialtyDecimalError.Size = new Size(161, 15);
            lblSpecialtyDecimalError.TabIndex = 11;
            lblSpecialtyDecimalError.Text = "Please enter a valid number";
            // 
            // lblSpecialtyBooleanError
            // 
            lblSpecialtyBooleanError.AutoSize = true;
            lblSpecialtyBooleanError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSpecialtyBooleanError.ForeColor = Color.Red;
            lblSpecialtyBooleanError.Location = new Point(24, 77);
            lblSpecialtyBooleanError.Name = "lblSpecialtyBooleanError";
            lblSpecialtyBooleanError.Size = new Size(133, 15);
            lblSpecialtyBooleanError.TabIndex = 12;
            lblSpecialtyBooleanError.Text = "Please select Yes or No";
            // 
            // lblSpecialtyDecimal
            // 
            lblSpecialtyDecimal.AutoSize = true;
            lblSpecialtyDecimal.Location = new Point(6, 108);
            lblSpecialtyDecimal.Name = "lblSpecialtyDecimal";
            lblSpecialtyDecimal.Size = new Size(103, 15);
            lblSpecialtyDecimal.TabIndex = 3;
            lblSpecialtyDecimal.Text = "Specialty Decimal:";
            // 
            // rdoSpecialtyYes
            // 
            rdoSpecialtyYes.AutoSize = true;
            rdoSpecialtyYes.Location = new Point(25, 55);
            rdoSpecialtyYes.Name = "rdoSpecialtyYes";
            rdoSpecialtyYes.Size = new Size(42, 19);
            rdoSpecialtyYes.TabIndex = 2;
            rdoSpecialtyYes.TabStop = true;
            rdoSpecialtyYes.Text = "Yes";
            rdoSpecialtyYes.UseVisualStyleBackColor = true;
            // 
            // lblSpecialtyBoolean
            // 
            lblSpecialtyBoolean.AutoSize = true;
            lblSpecialtyBoolean.Location = new Point(6, 37);
            lblSpecialtyBoolean.Name = "lblSpecialtyBoolean";
            lblSpecialtyBoolean.Size = new Size(103, 15);
            lblSpecialtyBoolean.TabIndex = 2;
            lblSpecialtyBoolean.Text = "Specialty Boolean:";
            // 
            // gbxStoreInventory
            // 
            gbxStoreInventory.Controls.Add(lstInventory);
            gbxStoreInventory.Location = new Point(260, 21);
            gbxStoreInventory.Name = "gbxStoreInventory";
            gbxStoreInventory.Size = new Size(200, 417);
            gbxStoreInventory.TabIndex = 2;
            gbxStoreInventory.TabStop = false;
            gbxStoreInventory.Text = "Store Inventory";
            // 
            // lstInventory
            // 
            lstInventory.FormattingEnabled = true;
            lstInventory.Location = new Point(6, 22);
            lstInventory.Name = "lstInventory";
            lstInventory.Size = new Size(188, 379);
            lstInventory.TabIndex = 3;
            // 
            // btnAddCart
            // 
            btnAddCart.Location = new Point(466, 203);
            btnAddCart.Name = "btnAddCart";
            btnAddCart.Size = new Size(75, 44);
            btnAddCart.TabIndex = 3;
            btnAddCart.Text = "Add to Cart";
            btnAddCart.UseVisualStyleBackColor = true;
            // 
            // gbxShoppingCart
            // 
            gbxShoppingCart.Controls.Add(lstShoppingCart);
            gbxShoppingCart.Location = new Point(547, 21);
            gbxShoppingCart.Name = "gbxShoppingCart";
            gbxShoppingCart.Size = new Size(200, 417);
            gbxShoppingCart.TabIndex = 4;
            gbxShoppingCart.TabStop = false;
            gbxShoppingCart.Text = "Shopping Cart";
            // 
            // lstShoppingCart
            // 
            lstShoppingCart.FormattingEnabled = true;
            lstShoppingCart.Location = new Point(6, 22);
            lstShoppingCart.Name = "lstShoppingCart";
            lstShoppingCart.Size = new Size(188, 379);
            lstShoppingCart.TabIndex = 3;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(608, 444);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(75, 23);
            btnCheckout.TabIndex = 5;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(608, 470);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(36, 15);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total:";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Location = new Point(650, 470);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(19, 15);
            lblTotalAmount.TabIndex = 7;
            lblTotalAmount.Text = "$0";
            // 
            // FrmVehicleStore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 615);
            Controls.Add(lblTotalAmount);
            Controls.Add(lblTotal);
            Controls.Add(btnCheckout);
            Controls.Add(gbxShoppingCart);
            Controls.Add(btnAddCart);
            Controls.Add(gbxStoreInventory);
            Controls.Add(gbxSpecialtyProperties);
            Controls.Add(gbxCreateVehicle);
            Name = "FrmVehicleStore";
            Text = "Vehicle Store";
            gbxCreateVehicle.ResumeLayout(false);
            gbxCreateVehicle.PerformLayout();
            gbxSpecialtyProperties.ResumeLayout(false);
            gbxSpecialtyProperties.PerformLayout();
            gbxStoreInventory.ResumeLayout(false);
            gbxShoppingCart.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbxCreateVehicle;
        private Label lblWheels;
        private Label lblPrice;
        private RadioButton rdoVehicle;
        private RadioButton rdoMotercycle;
        private Label lblYear;
        private RadioButton rdoPickup;
        private Label lblModel;
        private RadioButton rdoCar;
        private Label lblMake;
        private Button btnCreate;
        private TextBox txtWheels;
        private TextBox txtPrice;
        private TextBox txtYear;
        private TextBox txtModel;
        private TextBox txtMake;
        private GroupBox gbxSpecialtyProperties;
        private Label lblSpecialtyDecimal;
        private Label lblSpecialtyBoolean;
        private RadioButton rdoSpecialtyYes;
        private RadioButton rdoSpecialtyNo;
        private TextBox txtSpecialtyDecimal;
        private GroupBox gbxStoreInventory;
        private ListBox lstInventory;
        private Button btnAddCart;
        private GroupBox gbxShoppingCart;
        private ListBox lstShoppingCart;
        private Label lblVehicleTypeError;
        private Button btnCheckout;
        private Label lblTotal;
        private Label lblTotalAmount;
        private Label lblWheelsError;
        private Label lblYearError;
        private Label lblPriceError;
        private Label lblModelError;
        private Label lblMakeError;
        private Label lblSpecialtyDecimalError;
        private Label lblSpecialtyBooleanError;
    }
}
