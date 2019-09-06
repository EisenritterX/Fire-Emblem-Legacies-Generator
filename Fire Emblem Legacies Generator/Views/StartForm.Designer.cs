namespace FELegaciesGeneratorTool.Views
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CreateUnitButton = new System.Windows.Forms.Button();
            this.CreateClassButton = new System.Windows.Forms.Button();
            this.CreateEquipmentButton = new System.Windows.Forms.Button();
            this.CreateItemButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.CreateUnitButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CreateClassButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CreateEquipmentButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CreateItemButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.QuitButton, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(757, 528);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // CreateUnitButton
            // 
            this.CreateUnitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateUnitButton.BackColor = System.Drawing.Color.Transparent;
            this.CreateUnitButton.BackgroundImage = global::FELegaciesGeneratorTool.Properties.Resources.Button_Blue;
            this.CreateUnitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CreateUnitButton.Image = ((System.Drawing.Image)(resources.GetObject("CreateUnitButton.Image")));
            this.CreateUnitButton.Location = new System.Drawing.Point(10, 10);
            this.CreateUnitButton.Margin = new System.Windows.Forms.Padding(10);
            this.CreateUnitButton.Name = "CreateUnitButton";
            this.CreateUnitButton.Size = new System.Drawing.Size(358, 112);
            this.CreateUnitButton.TabIndex = 0;
            this.CreateUnitButton.Text = "Create Unit";
            this.CreateUnitButton.UseVisualStyleBackColor = false;
            this.CreateUnitButton.Click += new System.EventHandler(this.CreateUnitButton_Click);
            // 
            // CreateClassButton
            // 
            this.CreateClassButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateClassButton.BackColor = System.Drawing.Color.Transparent;
            this.CreateClassButton.BackgroundImage = global::FELegaciesGeneratorTool.Properties.Resources.Button_Blue;
            this.CreateClassButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CreateClassButton.Image = global::FELegaciesGeneratorTool.Properties.Resources.Button_Blue;
            this.CreateClassButton.Location = new System.Drawing.Point(388, 10);
            this.CreateClassButton.Margin = new System.Windows.Forms.Padding(10);
            this.CreateClassButton.Name = "CreateClassButton";
            this.CreateClassButton.Size = new System.Drawing.Size(359, 112);
            this.CreateClassButton.TabIndex = 1;
            this.CreateClassButton.Text = "Create Class";
            this.CreateClassButton.UseVisualStyleBackColor = false;
            this.CreateClassButton.Click += new System.EventHandler(this.CreateClassButton_Click);
            // 
            // CreateEquipmentButton
            // 
            this.CreateEquipmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateEquipmentButton.BackColor = System.Drawing.Color.Transparent;
            this.CreateEquipmentButton.BackgroundImage = global::FELegaciesGeneratorTool.Properties.Resources.Button_Blue;
            this.CreateEquipmentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CreateEquipmentButton.Image = ((System.Drawing.Image)(resources.GetObject("CreateEquipmentButton.Image")));
            this.CreateEquipmentButton.Location = new System.Drawing.Point(10, 142);
            this.CreateEquipmentButton.Margin = new System.Windows.Forms.Padding(10);
            this.CreateEquipmentButton.Name = "CreateEquipmentButton";
            this.CreateEquipmentButton.Size = new System.Drawing.Size(358, 112);
            this.CreateEquipmentButton.TabIndex = 2;
            this.CreateEquipmentButton.Text = "Create Equipment";
            this.CreateEquipmentButton.UseVisualStyleBackColor = false;
            // 
            // CreateItemButton
            // 
            this.CreateItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateItemButton.BackColor = System.Drawing.Color.Transparent;
            this.CreateItemButton.BackgroundImage = global::FELegaciesGeneratorTool.Properties.Resources.Button_Blue;
            this.CreateItemButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CreateItemButton.Image = ((System.Drawing.Image)(resources.GetObject("CreateItemButton.Image")));
            this.CreateItemButton.Location = new System.Drawing.Point(388, 142);
            this.CreateItemButton.Margin = new System.Windows.Forms.Padding(10);
            this.CreateItemButton.Name = "CreateItemButton";
            this.CreateItemButton.Size = new System.Drawing.Size(359, 112);
            this.CreateItemButton.TabIndex = 3;
            this.CreateItemButton.Text = "Create Item";
            this.CreateItemButton.UseVisualStyleBackColor = false;
            // 
            // QuitButton
            // 
            this.QuitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuitButton.BackColor = System.Drawing.Color.Transparent;
            this.QuitButton.BackgroundImage = global::FELegaciesGeneratorTool.Properties.Resources.Red_Button;
            this.QuitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.SetColumnSpan(this.QuitButton, 2);
            this.QuitButton.Image = ((System.Drawing.Image)(resources.GetObject("QuitButton.Image")));
            this.QuitButton.Location = new System.Drawing.Point(10, 406);
            this.QuitButton.Margin = new System.Windows.Forms.Padding(10);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(737, 112);
            this.QuitButton.TabIndex = 4;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = false;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // StartForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "StartForm";
            this.Text = "Start Creating...";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button CreateUnitButton;
        private System.Windows.Forms.Button CreateClassButton;
        private System.Windows.Forms.Button CreateEquipmentButton;
        private System.Windows.Forms.Button CreateItemButton;
        private System.Windows.Forms.Button QuitButton;
    }
}
