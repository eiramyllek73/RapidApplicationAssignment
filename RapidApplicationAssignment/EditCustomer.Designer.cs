namespace RapidApplicationAssignment
{
    partial class EditCustomer
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
            System.Windows.Forms.Label customerIdLabel;
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
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.furzAFlynShopDBDataSet = new RapidApplicationAssignment.FurzAFlynShopDBDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new RapidApplicationAssignment.FurzAFlynShopDBDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new RapidApplicationAssignment.FurzAFlynShopDBDataSetTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customerIdTextBox = new System.Windows.Forms.TextBox();
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            customerIdLabel = new System.Windows.Forms.Label();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(623, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(importantNotesLabel);
            this.groupBox1.Controls.Add(this.importantNotesTextBox);
            this.groupBox1.Controls.Add(vetInfoLabel);
            this.groupBox1.Controls.Add(this.vetInfoTextBox);
            this.groupBox1.Controls.Add(secondaryContactPhoneLabel);
            this.groupBox1.Controls.Add(this.secondaryContactPhoneTextBox);
            this.groupBox1.Controls.Add(secondaryContactNameLabel);
            this.groupBox1.Controls.Add(this.secondaryContactNameTextBox);
            this.groupBox1.Controls.Add(primaryAlternatePhoneLabel);
            this.groupBox1.Controls.Add(this.primaryAlternatePhoneTextBox);
            this.groupBox1.Controls.Add(primaryContactEmailLabel);
            this.groupBox1.Controls.Add(this.primaryContactEmailTextBox);
            this.groupBox1.Controls.Add(primaryContactPhoneLabel);
            this.groupBox1.Controls.Add(this.primaryContactPhoneTextBox);
            this.groupBox1.Controls.Add(primaryContactLastNameLabel);
            this.groupBox1.Controls.Add(this.primaryContactLastNameTextBox);
            this.groupBox1.Controls.Add(primaryContactFirstNameLabel);
            this.groupBox1.Controls.Add(this.primaryContactFirstNameTextBox);
            this.groupBox1.Controls.Add(sizeCategoryLabel);
            this.groupBox1.Controls.Add(this.sizeCategoryTextBox);
            this.groupBox1.Controls.Add(breedTypeLabel);
            this.groupBox1.Controls.Add(this.breedTypeTextBox);
            this.groupBox1.Controls.Add(ageAtFirstVisitLabel);
            this.groupBox1.Controls.Add(this.ageAtFirstVisitTextBox);
            this.groupBox1.Controls.Add(nameOfPetLabel);
            this.groupBox1.Controls.Add(this.nameOfPetTextBox);
            this.groupBox1.Controls.Add(customerIdLabel);
            this.groupBox1.Controls.Add(this.customerIdTextBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 533);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // customerIdLabel
            // 
            customerIdLabel.AutoSize = true;
            customerIdLabel.Location = new System.Drawing.Point(7, 13);
            customerIdLabel.Name = "customerIdLabel";
            customerIdLabel.Size = new System.Drawing.Size(66, 13);
            customerIdLabel.TabIndex = 0;
            customerIdLabel.Text = "Customer Id:";
            // 
            // customerIdTextBox
            // 
            this.customerIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerId", true));
            this.customerIdTextBox.Location = new System.Drawing.Point(79, 10);
            this.customerIdTextBox.Name = "customerIdTextBox";
            this.customerIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.customerIdTextBox.TabIndex = 1;
            // 
            // nameOfPetLabel
            // 
            nameOfPetLabel.AutoSize = true;
            nameOfPetLabel.Location = new System.Drawing.Point(10, 33);
            nameOfPetLabel.Name = "nameOfPetLabel";
            nameOfPetLabel.Size = new System.Drawing.Size(71, 13);
            nameOfPetLabel.TabIndex = 2;
            nameOfPetLabel.Text = "Name Of Pet:";
            // 
            // nameOfPetTextBox
            // 
            this.nameOfPetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "NameOfPet", true));
            this.nameOfPetTextBox.Location = new System.Drawing.Point(87, 30);
            this.nameOfPetTextBox.Name = "nameOfPetTextBox";
            this.nameOfPetTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameOfPetTextBox.TabIndex = 3;
            // 
            // ageAtFirstVisitLabel
            // 
            ageAtFirstVisitLabel.AutoSize = true;
            ageAtFirstVisitLabel.Location = new System.Drawing.Point(6, 66);
            ageAtFirstVisitLabel.Name = "ageAtFirstVisitLabel";
            ageAtFirstVisitLabel.Size = new System.Drawing.Size(86, 13);
            ageAtFirstVisitLabel.TabIndex = 4;
            ageAtFirstVisitLabel.Text = "Age At First Visit:";
            // 
            // ageAtFirstVisitTextBox
            // 
            this.ageAtFirstVisitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "AgeAtFirstVisit", true));
            this.ageAtFirstVisitTextBox.Location = new System.Drawing.Point(98, 63);
            this.ageAtFirstVisitTextBox.Name = "ageAtFirstVisitTextBox";
            this.ageAtFirstVisitTextBox.Size = new System.Drawing.Size(100, 20);
            this.ageAtFirstVisitTextBox.TabIndex = 5;
            // 
            // breedTypeLabel
            // 
            breedTypeLabel.AutoSize = true;
            breedTypeLabel.Location = new System.Drawing.Point(18, 96);
            breedTypeLabel.Name = "breedTypeLabel";
            breedTypeLabel.Size = new System.Drawing.Size(65, 13);
            breedTypeLabel.TabIndex = 6;
            breedTypeLabel.Text = "Breed Type:";
            // 
            // breedTypeTextBox
            // 
            this.breedTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "BreedType", true));
            this.breedTypeTextBox.Location = new System.Drawing.Point(89, 93);
            this.breedTypeTextBox.Name = "breedTypeTextBox";
            this.breedTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.breedTypeTextBox.TabIndex = 7;
            // 
            // sizeCategoryLabel
            // 
            sizeCategoryLabel.AutoSize = true;
            sizeCategoryLabel.Location = new System.Drawing.Point(10, 121);
            sizeCategoryLabel.Name = "sizeCategoryLabel";
            sizeCategoryLabel.Size = new System.Drawing.Size(75, 13);
            sizeCategoryLabel.TabIndex = 8;
            sizeCategoryLabel.Text = "Size Category:";
            // 
            // sizeCategoryTextBox
            // 
            this.sizeCategoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "SizeCategory", true));
            this.sizeCategoryTextBox.Location = new System.Drawing.Point(91, 118);
            this.sizeCategoryTextBox.Name = "sizeCategoryTextBox";
            this.sizeCategoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.sizeCategoryTextBox.TabIndex = 9;
            // 
            // primaryContactFirstNameLabel
            // 
            primaryContactFirstNameLabel.AutoSize = true;
            primaryContactFirstNameLabel.Location = new System.Drawing.Point(17, 141);
            primaryContactFirstNameLabel.Name = "primaryContactFirstNameLabel";
            primaryContactFirstNameLabel.Size = new System.Drawing.Size(137, 13);
            primaryContactFirstNameLabel.TabIndex = 10;
            primaryContactFirstNameLabel.Text = "Primary Contact First Name:";
            // 
            // primaryContactFirstNameTextBox
            // 
            this.primaryContactFirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "PrimaryContactFirstName", true));
            this.primaryContactFirstNameTextBox.Location = new System.Drawing.Point(160, 138);
            this.primaryContactFirstNameTextBox.Name = "primaryContactFirstNameTextBox";
            this.primaryContactFirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.primaryContactFirstNameTextBox.TabIndex = 11;
            // 
            // primaryContactLastNameLabel
            // 
            primaryContactLastNameLabel.AutoSize = true;
            primaryContactLastNameLabel.Location = new System.Drawing.Point(10, 166);
            primaryContactLastNameLabel.Name = "primaryContactLastNameLabel";
            primaryContactLastNameLabel.Size = new System.Drawing.Size(138, 13);
            primaryContactLastNameLabel.TabIndex = 12;
            primaryContactLastNameLabel.Text = "Primary Contact Last Name:";
            // 
            // primaryContactLastNameTextBox
            // 
            this.primaryContactLastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "PrimaryContactLastName", true));
            this.primaryContactLastNameTextBox.Location = new System.Drawing.Point(154, 163);
            this.primaryContactLastNameTextBox.Name = "primaryContactLastNameTextBox";
            this.primaryContactLastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.primaryContactLastNameTextBox.TabIndex = 13;
            // 
            // primaryContactPhoneLabel
            // 
            primaryContactPhoneLabel.AutoSize = true;
            primaryContactPhoneLabel.Location = new System.Drawing.Point(16, 191);
            primaryContactPhoneLabel.Name = "primaryContactPhoneLabel";
            primaryContactPhoneLabel.Size = new System.Drawing.Size(118, 13);
            primaryContactPhoneLabel.TabIndex = 14;
            primaryContactPhoneLabel.Text = "Primary Contact Phone:";
            // 
            // primaryContactPhoneTextBox
            // 
            this.primaryContactPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "PrimaryContactPhone", true));
            this.primaryContactPhoneTextBox.Location = new System.Drawing.Point(140, 188);
            this.primaryContactPhoneTextBox.Name = "primaryContactPhoneTextBox";
            this.primaryContactPhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.primaryContactPhoneTextBox.TabIndex = 15;
            // 
            // primaryContactEmailLabel
            // 
            primaryContactEmailLabel.AutoSize = true;
            primaryContactEmailLabel.Location = new System.Drawing.Point(21, 208);
            primaryContactEmailLabel.Name = "primaryContactEmailLabel";
            primaryContactEmailLabel.Size = new System.Drawing.Size(112, 13);
            primaryContactEmailLabel.TabIndex = 16;
            primaryContactEmailLabel.Text = "Primary Contact Email:";
            // 
            // primaryContactEmailTextBox
            // 
            this.primaryContactEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "PrimaryContactEmail", true));
            this.primaryContactEmailTextBox.Location = new System.Drawing.Point(139, 205);
            this.primaryContactEmailTextBox.Name = "primaryContactEmailTextBox";
            this.primaryContactEmailTextBox.Size = new System.Drawing.Size(100, 20);
            this.primaryContactEmailTextBox.TabIndex = 17;
            // 
            // primaryAlternatePhoneLabel
            // 
            primaryAlternatePhoneLabel.AutoSize = true;
            primaryAlternatePhoneLabel.Location = new System.Drawing.Point(27, 235);
            primaryAlternatePhoneLabel.Name = "primaryAlternatePhoneLabel";
            primaryAlternatePhoneLabel.Size = new System.Drawing.Size(123, 13);
            primaryAlternatePhoneLabel.TabIndex = 18;
            primaryAlternatePhoneLabel.Text = "Primary Alternate Phone:";
            // 
            // primaryAlternatePhoneTextBox
            // 
            this.primaryAlternatePhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "PrimaryAlternatePhone", true));
            this.primaryAlternatePhoneTextBox.Location = new System.Drawing.Point(156, 232);
            this.primaryAlternatePhoneTextBox.Name = "primaryAlternatePhoneTextBox";
            this.primaryAlternatePhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.primaryAlternatePhoneTextBox.TabIndex = 19;
            // 
            // secondaryContactNameLabel
            // 
            secondaryContactNameLabel.AutoSize = true;
            secondaryContactNameLabel.Location = new System.Drawing.Point(34, 266);
            secondaryContactNameLabel.Name = "secondaryContactNameLabel";
            secondaryContactNameLabel.Size = new System.Drawing.Size(132, 13);
            secondaryContactNameLabel.TabIndex = 20;
            secondaryContactNameLabel.Text = "Secondary Contact Name:";
            // 
            // secondaryContactNameTextBox
            // 
            this.secondaryContactNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "SecondaryContactName", true));
            this.secondaryContactNameTextBox.Location = new System.Drawing.Point(172, 263);
            this.secondaryContactNameTextBox.Name = "secondaryContactNameTextBox";
            this.secondaryContactNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.secondaryContactNameTextBox.TabIndex = 21;
            // 
            // secondaryContactPhoneLabel
            // 
            secondaryContactPhoneLabel.AutoSize = true;
            secondaryContactPhoneLabel.Location = new System.Drawing.Point(33, 296);
            secondaryContactPhoneLabel.Name = "secondaryContactPhoneLabel";
            secondaryContactPhoneLabel.Size = new System.Drawing.Size(135, 13);
            secondaryContactPhoneLabel.TabIndex = 22;
            secondaryContactPhoneLabel.Text = "Secondary Contact Phone:";
            // 
            // secondaryContactPhoneTextBox
            // 
            this.secondaryContactPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "SecondaryContactPhone", true));
            this.secondaryContactPhoneTextBox.Location = new System.Drawing.Point(174, 293);
            this.secondaryContactPhoneTextBox.Name = "secondaryContactPhoneTextBox";
            this.secondaryContactPhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.secondaryContactPhoneTextBox.TabIndex = 23;
            // 
            // vetInfoLabel
            // 
            vetInfoLabel.AutoSize = true;
            vetInfoLabel.Location = new System.Drawing.Point(29, 322);
            vetInfoLabel.Name = "vetInfoLabel";
            vetInfoLabel.Size = new System.Drawing.Size(47, 13);
            vetInfoLabel.TabIndex = 24;
            vetInfoLabel.Text = "Vet Info:";
            // 
            // vetInfoTextBox
            // 
            this.vetInfoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "VetInfo", true));
            this.vetInfoTextBox.Location = new System.Drawing.Point(82, 319);
            this.vetInfoTextBox.Name = "vetInfoTextBox";
            this.vetInfoTextBox.Size = new System.Drawing.Size(100, 20);
            this.vetInfoTextBox.TabIndex = 25;
            // 
            // importantNotesLabel
            // 
            importantNotesLabel.AutoSize = true;
            importantNotesLabel.Location = new System.Drawing.Point(31, 348);
            importantNotesLabel.Name = "importantNotesLabel";
            importantNotesLabel.Size = new System.Drawing.Size(85, 13);
            importantNotesLabel.TabIndex = 26;
            importantNotesLabel.Text = "Important Notes:";
            // 
            // importantNotesTextBox
            // 
            this.importantNotesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "ImportantNotes", true));
            this.importantNotesTextBox.Location = new System.Drawing.Point(122, 345);
            this.importantNotesTextBox.Name = "importantNotesTextBox";
            this.importantNotesTextBox.Size = new System.Drawing.Size(100, 20);
            this.importantNotesTextBox.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(410, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 86);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 35;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(410, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 36;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // EditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 567);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EditCustomer";
            this.Text = "EditCustomer";
            this.Load += new System.EventHandler(this.EditCustomer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.furzAFlynShopDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private FurzAFlynShopDBDataSet furzAFlynShopDBDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private FurzAFlynShopDBDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private FurzAFlynShopDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox importantNotesTextBox;
        private System.Windows.Forms.TextBox vetInfoTextBox;
        private System.Windows.Forms.TextBox secondaryContactPhoneTextBox;
        private System.Windows.Forms.TextBox secondaryContactNameTextBox;
        private System.Windows.Forms.TextBox primaryAlternatePhoneTextBox;
        private System.Windows.Forms.TextBox primaryContactEmailTextBox;
        private System.Windows.Forms.TextBox primaryContactPhoneTextBox;
        private System.Windows.Forms.TextBox primaryContactLastNameTextBox;
        private System.Windows.Forms.TextBox primaryContactFirstNameTextBox;
        private System.Windows.Forms.TextBox sizeCategoryTextBox;
        private System.Windows.Forms.TextBox breedTypeTextBox;
        private System.Windows.Forms.TextBox ageAtFirstVisitTextBox;
        private System.Windows.Forms.TextBox nameOfPetTextBox;
        private System.Windows.Forms.TextBox customerIdTextBox;
    }
}