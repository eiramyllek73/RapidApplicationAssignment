namespace RapidApplicationAssignment
{
    partial class AddCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameOfPetLabel;
            System.Windows.Forms.Label ageAtFirstVisitLabel;
            System.Windows.Forms.Label breedTypeLabel;
            System.Windows.Forms.Label sizeCategoryLabel;
            System.Windows.Forms.Label primaryContactFirstNameLabel;
            System.Windows.Forms.Label primaryContactLastNameLabel;
            System.Windows.Forms.Label primaryContactPhoneLabel;
            System.Windows.Forms.Label primaryContactEmailLabel;
            System.Windows.Forms.Label primaryAlternatePhoneLabel;
            System.Windows.Forms.Label secondaryContactNameLabel;
            System.Windows.Forms.Label secondaryContactPhoneLabel;
            System.Windows.Forms.Label vetInfoLabel;
            System.Windows.Forms.Label importantNotesLabel;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAppointmentLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCustomerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.furzAFlynShopDBDataSet = new RapidApplicationAssignment.FurzAFlynShopDBDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new RapidApplicationAssignment.FurzAFlynShopDBDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new RapidApplicationAssignment.FurzAFlynShopDBDataSetTableAdapters.TableAdapterManager();
            this.nameOfPetTextBox = new System.Windows.Forms.TextBox();
            this.ageAtFirstVisitTextBox = new System.Windows.Forms.TextBox();
            this.breedTypeTextBox = new System.Windows.Forms.TextBox();
            this.sizeCategoryTextBox = new System.Windows.Forms.TextBox();
            this.primaryContactFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.primaryContactLastNameTextBox = new System.Windows.Forms.TextBox();
            this.primaryContactPhoneTextBox = new System.Windows.Forms.TextBox();
            this.primaryContactEmailTextBox = new System.Windows.Forms.TextBox();
            this.primaryAlternatePhoneTextBox = new System.Windows.Forms.TextBox();
            this.secondaryContactNameTextBox = new System.Windows.Forms.TextBox();
            this.secondaryContactPhoneTextBox = new System.Windows.Forms.TextBox();
            this.vetInfoTextBox = new System.Windows.Forms.TextBox();
            this.importantNotesTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveDetailsButton = new System.Windows.Forms.Button();
            this.cancelEditButton = new System.Windows.Forms.Button();
            nameOfPetLabel = new System.Windows.Forms.Label();
            ageAtFirstVisitLabel = new System.Windows.Forms.Label();
            breedTypeLabel = new System.Windows.Forms.Label();
            sizeCategoryLabel = new System.Windows.Forms.Label();
            primaryContactFirstNameLabel = new System.Windows.Forms.Label();
            primaryContactLastNameLabel = new System.Windows.Forms.Label();
            primaryContactPhoneLabel = new System.Windows.Forms.Label();
            primaryContactEmailLabel = new System.Windows.Forms.Label();
            primaryAlternatePhoneLabel = new System.Windows.Forms.Label();
            secondaryContactNameLabel = new System.Windows.Forms.Label();
            secondaryContactPhoneLabel = new System.Windows.Forms.Label();
            vetInfoLabel = new System.Windows.Forms.Label();
            importantNotesLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.furzAFlynShopDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameOfPetLabel
            // 
            nameOfPetLabel.AutoSize = true;
            nameOfPetLabel.Location = new System.Drawing.Point(3, 55);
            nameOfPetLabel.Name = "nameOfPetLabel";
            nameOfPetLabel.Size = new System.Drawing.Size(68, 13);
            nameOfPetLabel.TabIndex = 2;
            nameOfPetLabel.Text = "Name of pet:";
            // 
            // ageAtFirstVisitLabel
            // 
            ageAtFirstVisitLabel.AutoSize = true;
            ageAtFirstVisitLabel.Location = new System.Drawing.Point(3, 85);
            ageAtFirstVisitLabel.Name = "ageAtFirstVisitLabel";
            ageAtFirstVisitLabel.Size = new System.Drawing.Size(81, 13);
            ageAtFirstVisitLabel.TabIndex = 4;
            ageAtFirstVisitLabel.Text = "Age at first visit:";
            // 
            // breedTypeLabel
            // 
            breedTypeLabel.AutoSize = true;
            breedTypeLabel.Location = new System.Drawing.Point(6, 110);
            breedTypeLabel.Name = "breedTypeLabel";
            breedTypeLabel.Size = new System.Drawing.Size(65, 13);
            breedTypeLabel.TabIndex = 6;
            breedTypeLabel.Text = "Breed Type:";
            // 
            // sizeCategoryLabel
            // 
            sizeCategoryLabel.AutoSize = true;
            sizeCategoryLabel.Location = new System.Drawing.Point(3, 140);
            sizeCategoryLabel.Name = "sizeCategoryLabel";
            sizeCategoryLabel.Size = new System.Drawing.Size(75, 13);
            sizeCategoryLabel.TabIndex = 8;
            sizeCategoryLabel.Text = "Size Category:";
            // 
            // primaryContactFirstNameLabel
            // 
            primaryContactFirstNameLabel.AutoSize = true;
            primaryContactFirstNameLabel.Location = new System.Drawing.Point(3, 171);
            primaryContactFirstNameLabel.Name = "primaryContactFirstNameLabel";
            primaryContactFirstNameLabel.Size = new System.Drawing.Size(137, 13);
            primaryContactFirstNameLabel.TabIndex = 10;
            primaryContactFirstNameLabel.Text = "Primary Contact First Name:";
            // 
            // primaryContactLastNameLabel
            // 
            primaryContactLastNameLabel.AutoSize = true;
            primaryContactLastNameLabel.Location = new System.Drawing.Point(3, 195);
            primaryContactLastNameLabel.Name = "primaryContactLastNameLabel";
            primaryContactLastNameLabel.Size = new System.Drawing.Size(138, 13);
            primaryContactLastNameLabel.TabIndex = 12;
            primaryContactLastNameLabel.Text = "Primary Contact Last Name:";
            // 
            // primaryContactPhoneLabel
            // 
            primaryContactPhoneLabel.AutoSize = true;
            primaryContactPhoneLabel.Location = new System.Drawing.Point(3, 218);
            primaryContactPhoneLabel.Name = "primaryContactPhoneLabel";
            primaryContactPhoneLabel.Size = new System.Drawing.Size(118, 13);
            primaryContactPhoneLabel.TabIndex = 14;
            primaryContactPhoneLabel.Text = "Primary Contact Phone:";
            // 
            // primaryContactEmailLabel
            // 
            primaryContactEmailLabel.AutoSize = true;
            primaryContactEmailLabel.Location = new System.Drawing.Point(8, 242);
            primaryContactEmailLabel.Name = "primaryContactEmailLabel";
            primaryContactEmailLabel.Size = new System.Drawing.Size(112, 13);
            primaryContactEmailLabel.TabIndex = 16;
            primaryContactEmailLabel.Text = "Primary Contact Email:";
            // 
            // primaryAlternatePhoneLabel
            // 
            primaryAlternatePhoneLabel.AutoSize = true;
            primaryAlternatePhoneLabel.Location = new System.Drawing.Point(10, 260);
            primaryAlternatePhoneLabel.Name = "primaryAlternatePhoneLabel";
            primaryAlternatePhoneLabel.Size = new System.Drawing.Size(123, 13);
            primaryAlternatePhoneLabel.TabIndex = 18;
            primaryAlternatePhoneLabel.Text = "Primary Alternate Phone:";
            // 
            // secondaryContactNameLabel
            // 
            secondaryContactNameLabel.AutoSize = true;
            secondaryContactNameLabel.Location = new System.Drawing.Point(16, 281);
            secondaryContactNameLabel.Name = "secondaryContactNameLabel";
            secondaryContactNameLabel.Size = new System.Drawing.Size(132, 13);
            secondaryContactNameLabel.TabIndex = 20;
            secondaryContactNameLabel.Text = "Secondary Contact Name:";
            // 
            // secondaryContactPhoneLabel
            // 
            secondaryContactPhoneLabel.AutoSize = true;
            secondaryContactPhoneLabel.Location = new System.Drawing.Point(23, 306);
            secondaryContactPhoneLabel.Name = "secondaryContactPhoneLabel";
            secondaryContactPhoneLabel.Size = new System.Drawing.Size(135, 13);
            secondaryContactPhoneLabel.TabIndex = 22;
            secondaryContactPhoneLabel.Text = "Secondary Contact Phone:";
            // 
            // vetInfoLabel
            // 
            vetInfoLabel.AutoSize = true;
            vetInfoLabel.Location = new System.Drawing.Point(12, 325);
            vetInfoLabel.Name = "vetInfoLabel";
            vetInfoLabel.Size = new System.Drawing.Size(47, 13);
            vetInfoLabel.TabIndex = 24;
            vetInfoLabel.Text = "Vet Info:";
            // 
            // importantNotesLabel
            // 
            importantNotesLabel.AutoSize = true;
            importantNotesLabel.Location = new System.Drawing.Point(20, 345);
            importantNotesLabel.Name = "importantNotesLabel";
            importantNotesLabel.Size = new System.Drawing.Size(85, 13);
            importantNotesLabel.TabIndex = 26;
            importantNotesLabel.Text = "Important Notes:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(431, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAppointmentLogToolStripMenuItem,
            this.editCustomerDetailsToolStripMenuItem,
            this.viewDirectoryToolStripMenuItem,
            this.goToMainMenuToolStripMenuItem,
            this.exitApplicationToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // viewAppointmentLogToolStripMenuItem
            // 
            this.viewAppointmentLogToolStripMenuItem.Name = "viewAppointmentLogToolStripMenuItem";
            this.viewAppointmentLogToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.viewAppointmentLogToolStripMenuItem.Text = "View Appt Log for this Customer";
            // 
            // editCustomerDetailsToolStripMenuItem
            // 
            this.editCustomerDetailsToolStripMenuItem.Name = "editCustomerDetailsToolStripMenuItem";
            this.editCustomerDetailsToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.editCustomerDetailsToolStripMenuItem.Text = "Edit Customer Details";
            // 
            // viewDirectoryToolStripMenuItem
            // 
            this.viewDirectoryToolStripMenuItem.Name = "viewDirectoryToolStripMenuItem";
            this.viewDirectoryToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.viewDirectoryToolStripMenuItem.Text = "View All Customer Directory";
            // 
            // goToMainMenuToolStripMenuItem
            // 
            this.goToMainMenuToolStripMenuItem.Name = "goToMainMenuToolStripMenuItem";
            this.goToMainMenuToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.goToMainMenuToolStripMenuItem.Text = "Go to Main Menu";
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.exitApplicationToolStripMenuItem.Text = "Exit Application";
            // 
            // furzAFlynShopDBDataSet
            // 
            this.furzAFlynShopDBDataSet.DataSetName = "FurzAFlynShopDBDataSet";
            this.furzAFlynShopDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.furzAFlynShopDBDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.UpdateOrder = RapidApplicationAssignment.FurzAFlynShopDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nameOfPetTextBox
            // 
            this.nameOfPetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "NameOfPet", true));
            this.nameOfPetTextBox.Location = new System.Drawing.Point(80, 52);
            this.nameOfPetTextBox.Name = "nameOfPetTextBox";
            this.nameOfPetTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameOfPetTextBox.TabIndex = 3;
            // 
            // ageAtFirstVisitTextBox
            // 
            this.ageAtFirstVisitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "AgeAtFirstVisit", true));
            this.ageAtFirstVisitTextBox.Location = new System.Drawing.Point(95, 82);
            this.ageAtFirstVisitTextBox.Name = "ageAtFirstVisitTextBox";
            this.ageAtFirstVisitTextBox.Size = new System.Drawing.Size(100, 20);
            this.ageAtFirstVisitTextBox.TabIndex = 5;
            // 
            // breedTypeTextBox
            // 
            this.breedTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "BreedType", true));
            this.breedTypeTextBox.Location = new System.Drawing.Point(77, 107);
            this.breedTypeTextBox.Name = "breedTypeTextBox";
            this.breedTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.breedTypeTextBox.TabIndex = 7;
            // 
            // sizeCategoryTextBox
            // 
            this.sizeCategoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "SizeCategory", true));
            this.sizeCategoryTextBox.Location = new System.Drawing.Point(84, 137);
            this.sizeCategoryTextBox.Name = "sizeCategoryTextBox";
            this.sizeCategoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.sizeCategoryTextBox.TabIndex = 9;
            // 
            // primaryContactFirstNameTextBox
            // 
            this.primaryContactFirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "PrimaryContactFirstName", true));
            this.primaryContactFirstNameTextBox.Location = new System.Drawing.Point(146, 168);
            this.primaryContactFirstNameTextBox.Name = "primaryContactFirstNameTextBox";
            this.primaryContactFirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.primaryContactFirstNameTextBox.TabIndex = 11;
            // 
            // primaryContactLastNameTextBox
            // 
            this.primaryContactLastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "PrimaryContactLastName", true));
            this.primaryContactLastNameTextBox.Location = new System.Drawing.Point(147, 192);
            this.primaryContactLastNameTextBox.Name = "primaryContactLastNameTextBox";
            this.primaryContactLastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.primaryContactLastNameTextBox.TabIndex = 13;
            // 
            // primaryContactPhoneTextBox
            // 
            this.primaryContactPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "PrimaryContactPhone", true));
            this.primaryContactPhoneTextBox.Location = new System.Drawing.Point(127, 215);
            this.primaryContactPhoneTextBox.Name = "primaryContactPhoneTextBox";
            this.primaryContactPhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.primaryContactPhoneTextBox.TabIndex = 15;
            // 
            // primaryContactEmailTextBox
            // 
            this.primaryContactEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "PrimaryContactEmail", true));
            this.primaryContactEmailTextBox.Location = new System.Drawing.Point(126, 239);
            this.primaryContactEmailTextBox.Name = "primaryContactEmailTextBox";
            this.primaryContactEmailTextBox.Size = new System.Drawing.Size(100, 20);
            this.primaryContactEmailTextBox.TabIndex = 17;
            // 
            // primaryAlternatePhoneTextBox
            // 
            this.primaryAlternatePhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "PrimaryAlternatePhone", true));
            this.primaryAlternatePhoneTextBox.Location = new System.Drawing.Point(139, 257);
            this.primaryAlternatePhoneTextBox.Name = "primaryAlternatePhoneTextBox";
            this.primaryAlternatePhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.primaryAlternatePhoneTextBox.TabIndex = 19;
            // 
            // secondaryContactNameTextBox
            // 
            this.secondaryContactNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "SecondaryContactName", true));
            this.secondaryContactNameTextBox.Location = new System.Drawing.Point(154, 278);
            this.secondaryContactNameTextBox.Name = "secondaryContactNameTextBox";
            this.secondaryContactNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.secondaryContactNameTextBox.TabIndex = 21;
            // 
            // secondaryContactPhoneTextBox
            // 
            this.secondaryContactPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "SecondaryContactPhone", true));
            this.secondaryContactPhoneTextBox.Location = new System.Drawing.Point(164, 303);
            this.secondaryContactPhoneTextBox.Name = "secondaryContactPhoneTextBox";
            this.secondaryContactPhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.secondaryContactPhoneTextBox.TabIndex = 23;
            // 
            // vetInfoTextBox
            // 
            this.vetInfoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "VetInfo", true));
            this.vetInfoTextBox.Location = new System.Drawing.Point(70, 322);
            this.vetInfoTextBox.Multiline = true;
            this.vetInfoTextBox.Name = "vetInfoTextBox";
            this.vetInfoTextBox.Size = new System.Drawing.Size(100, 20);
            this.vetInfoTextBox.TabIndex = 25;
            // 
            // importantNotesTextBox
            // 
            this.importantNotesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "ImportantNotes", true));
            this.importantNotesTextBox.Location = new System.Drawing.Point(111, 342);
            this.importantNotesTextBox.Multiline = true;
            this.importantNotesTextBox.Name = "importantNotesTextBox";
            this.importantNotesTextBox.Size = new System.Drawing.Size(100, 20);
            this.importantNotesTextBox.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(319, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // saveDetailsButton
            // 
            this.saveDetailsButton.Location = new System.Drawing.Point(262, 374);
            this.saveDetailsButton.Name = "saveDetailsButton";
            this.saveDetailsButton.Size = new System.Drawing.Size(75, 23);
            this.saveDetailsButton.TabIndex = 29;
            this.saveDetailsButton.Text = "Save";
            this.saveDetailsButton.UseVisualStyleBackColor = true;
            // 
            // cancelEditButton
            // 
            this.cancelEditButton.Location = new System.Drawing.Point(343, 374);
            this.cancelEditButton.Name = "cancelEditButton";
            this.cancelEditButton.Size = new System.Drawing.Size(75, 23);
            this.cancelEditButton.TabIndex = 30;
            this.cancelEditButton.Text = "Cancel";
            this.cancelEditButton.UseVisualStyleBackColor = true;
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 421);
            this.Controls.Add(this.cancelEditButton);
            this.Controls.Add(this.saveDetailsButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(importantNotesLabel);
            this.Controls.Add(this.importantNotesTextBox);
            this.Controls.Add(vetInfoLabel);
            this.Controls.Add(this.vetInfoTextBox);
            this.Controls.Add(secondaryContactPhoneLabel);
            this.Controls.Add(this.secondaryContactPhoneTextBox);
            this.Controls.Add(secondaryContactNameLabel);
            this.Controls.Add(this.secondaryContactNameTextBox);
            this.Controls.Add(primaryAlternatePhoneLabel);
            this.Controls.Add(this.primaryAlternatePhoneTextBox);
            this.Controls.Add(primaryContactEmailLabel);
            this.Controls.Add(this.primaryContactEmailTextBox);
            this.Controls.Add(primaryContactPhoneLabel);
            this.Controls.Add(this.primaryContactPhoneTextBox);
            this.Controls.Add(primaryContactLastNameLabel);
            this.Controls.Add(this.primaryContactLastNameTextBox);
            this.Controls.Add(primaryContactFirstNameLabel);
            this.Controls.Add(this.primaryContactFirstNameTextBox);
            this.Controls.Add(sizeCategoryLabel);
            this.Controls.Add(this.sizeCategoryTextBox);
            this.Controls.Add(breedTypeLabel);
            this.Controls.Add(this.breedTypeTextBox);
            this.Controls.Add(ageAtFirstVisitLabel);
            this.Controls.Add(this.ageAtFirstVisitTextBox);
            this.Controls.Add(nameOfPetLabel);
            this.Controls.Add(this.nameOfPetTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Profile";
            this.Load += new System.EventHandler(this.CustomerProfile_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.furzAFlynShopDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private FurzAFlynShopDBDataSet furzAFlynShopDBDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private FurzAFlynShopDBDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private FurzAFlynShopDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewAppointmentLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToMainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.TextBox nameOfPetTextBox;
        private System.Windows.Forms.TextBox ageAtFirstVisitTextBox;
        private System.Windows.Forms.TextBox breedTypeTextBox;
        private System.Windows.Forms.TextBox sizeCategoryTextBox;
        private System.Windows.Forms.TextBox primaryContactFirstNameTextBox;
        private System.Windows.Forms.TextBox primaryContactLastNameTextBox;
        private System.Windows.Forms.TextBox primaryContactPhoneTextBox;
        private System.Windows.Forms.TextBox primaryContactEmailTextBox;
        private System.Windows.Forms.TextBox primaryAlternatePhoneTextBox;
        private System.Windows.Forms.TextBox secondaryContactNameTextBox;
        private System.Windows.Forms.TextBox secondaryContactPhoneTextBox;
        private System.Windows.Forms.TextBox vetInfoTextBox;
        private System.Windows.Forms.TextBox importantNotesTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button saveDetailsButton;
        private System.Windows.Forms.Button cancelEditButton;
        private System.Windows.Forms.ToolStripMenuItem editCustomerDetailsToolStripMenuItem;
    }
}