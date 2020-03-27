namespace WindowsFormsApplication1
{
    partial class GerirUtilizadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerirUtilizadores));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label e_mailLabel;
            System.Windows.Forms.Label data_nascLabel;
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label passLabel;
            System.Windows.Forms.Label nivelLabel;
            System.Windows.Forms.Label departamentoLabel;
            this.dataSet1 = new WindowsFormsApplication1.DataSet1();
            this.utilizadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilizadoresTableAdapter = new WindowsFormsApplication1.DataSet1TableAdapters.UtilizadoresTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.DataSet1TableAdapters.TableAdapterManager();
            this.utilizadoresBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.utilizadoresBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.utilizadoresDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.e_mailTextBox = new System.Windows.Forms.TextBox();
            this.data_nascDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.nivelTextBox = new System.Windows.Forms.TextBox();
            this.departamentoTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            e_mailLabel = new System.Windows.Forms.Label();
            data_nascLabel = new System.Windows.Forms.Label();
            loginLabel = new System.Windows.Forms.Label();
            passLabel = new System.Windows.Forms.Label();
            nivelLabel = new System.Windows.Forms.Label();
            departamentoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizadoresBindingNavigator)).BeginInit();
            this.utilizadoresBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utilizadoresDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilizadoresBindingSource
            // 
            this.utilizadoresBindingSource.DataMember = "Utilizadores";
            this.utilizadoresBindingSource.DataSource = this.dataSet1;
            // 
            // utilizadoresTableAdapter
            // 
            this.utilizadoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilizadoresTableAdapter = this.utilizadoresTableAdapter;
            // 
            // utilizadoresBindingNavigator
            // 
            this.utilizadoresBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.utilizadoresBindingNavigator.BindingSource = this.utilizadoresBindingSource;
            this.utilizadoresBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.utilizadoresBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.utilizadoresBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.utilizadoresBindingNavigatorSaveItem});
            this.utilizadoresBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.utilizadoresBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.utilizadoresBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.utilizadoresBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.utilizadoresBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.utilizadoresBindingNavigator.Name = "utilizadoresBindingNavigator";
            this.utilizadoresBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.utilizadoresBindingNavigator.Size = new System.Drawing.Size(984, 31);
            this.utilizadoresBindingNavigator.TabIndex = 0;
            this.utilizadoresBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 25);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // utilizadoresBindingNavigatorSaveItem
            // 
            this.utilizadoresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.utilizadoresBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("utilizadoresBindingNavigatorSaveItem.Image")));
            this.utilizadoresBindingNavigatorSaveItem.Name = "utilizadoresBindingNavigatorSaveItem";
            this.utilizadoresBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.utilizadoresBindingNavigatorSaveItem.Text = "Save Data";
            this.utilizadoresBindingNavigatorSaveItem.Click += new System.EventHandler(this.utilizadoresBindingNavigatorSaveItem_Click);
            // 
            // utilizadoresDataGridView
            // 
            this.utilizadoresDataGridView.AutoGenerateColumns = false;
            this.utilizadoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.utilizadoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.utilizadoresDataGridView.DataSource = this.utilizadoresBindingSource;
            this.utilizadoresDataGridView.Location = new System.Drawing.Point(12, 51);
            this.utilizadoresDataGridView.Name = "utilizadoresDataGridView";
            this.utilizadoresDataGridView.RowTemplate.Height = 28;
            this.utilizadoresDataGridView.Size = new System.Drawing.Size(939, 141);
            this.utilizadoresDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "e-mail";
            this.dataGridViewTextBoxColumn3.HeaderText = "e-mail";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "data_nasc";
            this.dataGridViewTextBoxColumn4.HeaderText = "data_nasc";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "login";
            this.dataGridViewTextBoxColumn5.HeaderText = "login";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "pass";
            this.dataGridViewTextBoxColumn6.HeaderText = "pass";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "nivel";
            this.dataGridViewTextBoxColumn7.HeaderText = "nivel";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "departamento";
            this.dataGridViewTextBoxColumn8.HeaderText = "departamento";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(37, 238);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(25, 20);
            idLabel.TabIndex = 2;
            idLabel.Text = "id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilizadoresBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(156, 235);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(795, 26);
            this.idTextBox.TabIndex = 3;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(37, 270);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(53, 20);
            nomeLabel.TabIndex = 4;
            nomeLabel.Text = "nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilizadoresBindingSource, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(156, 267);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(795, 26);
            this.nomeTextBox.TabIndex = 5;
            // 
            // e_mailLabel
            // 
            e_mailLabel.AutoSize = true;
            e_mailLabel.Location = new System.Drawing.Point(37, 302);
            e_mailLabel.Name = "e_mailLabel";
            e_mailLabel.Size = new System.Drawing.Size(55, 20);
            e_mailLabel.TabIndex = 6;
            e_mailLabel.Text = "e-mail:";
            // 
            // e_mailTextBox
            // 
            this.e_mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilizadoresBindingSource, "e-mail", true));
            this.e_mailTextBox.Location = new System.Drawing.Point(156, 299);
            this.e_mailTextBox.Name = "e_mailTextBox";
            this.e_mailTextBox.Size = new System.Drawing.Size(795, 26);
            this.e_mailTextBox.TabIndex = 7;
            // 
            // data_nascLabel
            // 
            data_nascLabel.AutoSize = true;
            data_nascLabel.Location = new System.Drawing.Point(37, 335);
            data_nascLabel.Name = "data_nascLabel";
            data_nascLabel.Size = new System.Drawing.Size(83, 20);
            data_nascLabel.TabIndex = 8;
            data_nascLabel.Text = "data nasc:";
            // 
            // data_nascDateTimePicker
            // 
            this.data_nascDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.utilizadoresBindingSource, "data_nasc", true));
            this.data_nascDateTimePicker.Location = new System.Drawing.Point(156, 331);
            this.data_nascDateTimePicker.Name = "data_nascDateTimePicker";
            this.data_nascDateTimePicker.Size = new System.Drawing.Size(795, 26);
            this.data_nascDateTimePicker.TabIndex = 9;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(37, 366);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(46, 20);
            loginLabel.TabIndex = 10;
            loginLabel.Text = "login:";
            // 
            // loginTextBox
            // 
            this.loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilizadoresBindingSource, "login", true));
            this.loginTextBox.Location = new System.Drawing.Point(156, 363);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(795, 26);
            this.loginTextBox.TabIndex = 11;
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Location = new System.Drawing.Point(37, 398);
            passLabel.Name = "passLabel";
            passLabel.Size = new System.Drawing.Size(47, 20);
            passLabel.TabIndex = 12;
            passLabel.Text = "pass:";
            // 
            // passTextBox
            // 
            this.passTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilizadoresBindingSource, "pass", true));
            this.passTextBox.Location = new System.Drawing.Point(156, 395);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(795, 26);
            this.passTextBox.TabIndex = 13;
            // 
            // nivelLabel
            // 
            nivelLabel.AutoSize = true;
            nivelLabel.Location = new System.Drawing.Point(37, 430);
            nivelLabel.Name = "nivelLabel";
            nivelLabel.Size = new System.Drawing.Size(44, 20);
            nivelLabel.TabIndex = 14;
            nivelLabel.Text = "nivel:";
            // 
            // nivelTextBox
            // 
            this.nivelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilizadoresBindingSource, "nivel", true));
            this.nivelTextBox.Location = new System.Drawing.Point(156, 427);
            this.nivelTextBox.Name = "nivelTextBox";
            this.nivelTextBox.Size = new System.Drawing.Size(795, 26);
            this.nivelTextBox.TabIndex = 15;
            // 
            // departamentoLabel
            // 
            departamentoLabel.AutoSize = true;
            departamentoLabel.Location = new System.Drawing.Point(37, 462);
            departamentoLabel.Name = "departamentoLabel";
            departamentoLabel.Size = new System.Drawing.Size(113, 20);
            departamentoLabel.TabIndex = 16;
            departamentoLabel.Text = "departamento:";
            // 
            // departamentoTextBox
            // 
            this.departamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilizadoresBindingSource, "departamento", true));
            this.departamentoTextBox.Location = new System.Drawing.Point(156, 459);
            this.departamentoTextBox.Name = "departamentoTextBox";
            this.departamentoTextBox.Size = new System.Drawing.Size(795, 26);
            this.departamentoTextBox.TabIndex = 17;
            // 
            // GerirUtilizadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 549);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(e_mailLabel);
            this.Controls.Add(this.e_mailTextBox);
            this.Controls.Add(data_nascLabel);
            this.Controls.Add(this.data_nascDateTimePicker);
            this.Controls.Add(loginLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(passLabel);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(nivelLabel);
            this.Controls.Add(this.nivelTextBox);
            this.Controls.Add(departamentoLabel);
            this.Controls.Add(this.departamentoTextBox);
            this.Controls.Add(this.utilizadoresDataGridView);
            this.Controls.Add(this.utilizadoresBindingNavigator);
            this.Name = "GerirUtilizadores";
            this.Text = "GerirUtilizadores";
            this.Load += new System.EventHandler(this.GerirUtilizadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizadoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizadoresBindingNavigator)).EndInit();
            this.utilizadoresBindingNavigator.ResumeLayout(false);
            this.utilizadoresBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utilizadoresDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource utilizadoresBindingSource;
        private DataSet1TableAdapters.UtilizadoresTableAdapter utilizadoresTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator utilizadoresBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton utilizadoresBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView utilizadoresDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox e_mailTextBox;
        private System.Windows.Forms.DateTimePicker data_nascDateTimePicker;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.TextBox nivelTextBox;
        private System.Windows.Forms.TextBox departamentoTextBox;
    }
}