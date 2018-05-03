namespace Interfaz_gráfica
{
    partial class Control
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
            System.Windows.Forms.Label estacionamientoLabel;
            System.Windows.Forms.Label lugaresLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control));
            this.dBIMDataSet = new Interfaz_gráfica.DBIMDataSet();
            this.estacionamientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estacionamientoTableAdapter = new Interfaz_gráfica.DBIMDataSetTableAdapters.EstacionamientoTableAdapter();
            this.tableAdapterManager = new Interfaz_gráfica.DBIMDataSetTableAdapters.TableAdapterManager();
            this.estacionamientoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.estacionamientoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.estacionamientoTextBox = new System.Windows.Forms.TextBox();
            this.lugaresTextBox = new System.Windows.Forms.TextBox();
            this.estacionamientoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            estacionamientoLabel = new System.Windows.Forms.Label();
            lugaresLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBIMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamientoBindingNavigator)).BeginInit();
            this.estacionamientoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamientoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // estacionamientoLabel
            // 
            estacionamientoLabel.AutoSize = true;
            estacionamientoLabel.Location = new System.Drawing.Point(43, 68);
            estacionamientoLabel.Name = "estacionamientoLabel";
            estacionamientoLabel.Size = new System.Drawing.Size(88, 13);
            estacionamientoLabel.TabIndex = 1;
            estacionamientoLabel.Text = "Estacionamiento:";
            // 
            // lugaresLabel
            // 
            lugaresLabel.AutoSize = true;
            lugaresLabel.Location = new System.Drawing.Point(83, 94);
            lugaresLabel.Name = "lugaresLabel";
            lugaresLabel.Size = new System.Drawing.Size(48, 13);
            lugaresLabel.TabIndex = 3;
            lugaresLabel.Text = "Lugares:";
            // 
            // dBIMDataSet
            // 
            this.dBIMDataSet.DataSetName = "DBIMDataSet";
            this.dBIMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estacionamientoBindingSource
            // 
            this.estacionamientoBindingSource.DataMember = "Estacionamiento";
            this.estacionamientoBindingSource.DataSource = this.dBIMDataSet;
            // 
            // estacionamientoTableAdapter
            // 
            this.estacionamientoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EstacionamientoTableAdapter = this.estacionamientoTableAdapter;
            this.tableAdapterManager.RegistroTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Interfaz_gráfica.DBIMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // estacionamientoBindingNavigator
            // 
            this.estacionamientoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.estacionamientoBindingNavigator.BindingSource = this.estacionamientoBindingSource;
            this.estacionamientoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.estacionamientoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.estacionamientoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.estacionamientoBindingNavigatorSaveItem});
            this.estacionamientoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.estacionamientoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.estacionamientoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.estacionamientoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.estacionamientoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.estacionamientoBindingNavigator.Name = "estacionamientoBindingNavigator";
            this.estacionamientoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.estacionamientoBindingNavigator.Size = new System.Drawing.Size(534, 25);
            this.estacionamientoBindingNavigator.TabIndex = 0;
            this.estacionamientoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // estacionamientoBindingNavigatorSaveItem
            // 
            this.estacionamientoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.estacionamientoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("estacionamientoBindingNavigatorSaveItem.Image")));
            this.estacionamientoBindingNavigatorSaveItem.Name = "estacionamientoBindingNavigatorSaveItem";
            this.estacionamientoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.estacionamientoBindingNavigatorSaveItem.Text = "Guardar datos";
            this.estacionamientoBindingNavigatorSaveItem.Click += new System.EventHandler(this.estacionamientoBindingNavigatorSaveItem_Click);
            // 
            // estacionamientoTextBox
            // 
            this.estacionamientoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estacionamientoBindingSource, "Estacionamiento", true));
            this.estacionamientoTextBox.Location = new System.Drawing.Point(137, 65);
            this.estacionamientoTextBox.Name = "estacionamientoTextBox";
            this.estacionamientoTextBox.Size = new System.Drawing.Size(100, 20);
            this.estacionamientoTextBox.TabIndex = 2;
            // 
            // lugaresTextBox
            // 
            this.lugaresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estacionamientoBindingSource, "Lugares", true));
            this.lugaresTextBox.Location = new System.Drawing.Point(137, 91);
            this.lugaresTextBox.Name = "lugaresTextBox";
            this.lugaresTextBox.Size = new System.Drawing.Size(100, 20);
            this.lugaresTextBox.TabIndex = 4;
            // 
            // estacionamientoDataGridView
            // 
            this.estacionamientoDataGridView.AutoGenerateColumns = false;
            this.estacionamientoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.estacionamientoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.estacionamientoDataGridView.DataSource = this.estacionamientoBindingSource;
            this.estacionamientoDataGridView.Location = new System.Drawing.Point(25, 117);
            this.estacionamientoDataGridView.Name = "estacionamientoDataGridView";
            this.estacionamientoDataGridView.Size = new System.Drawing.Size(300, 238);
            this.estacionamientoDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Estacionamiento";
            this.dataGridViewTextBoxColumn1.HeaderText = "Estacionamiento";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Lugares";
            this.dataGridViewTextBoxColumn2.HeaderText = "Lugares";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 417);
            this.Controls.Add(this.estacionamientoDataGridView);
            this.Controls.Add(lugaresLabel);
            this.Controls.Add(this.lugaresTextBox);
            this.Controls.Add(estacionamientoLabel);
            this.Controls.Add(this.estacionamientoTextBox);
            this.Controls.Add(this.estacionamientoBindingNavigator);
            this.Name = "Control";
            this.Text = "Control";
            this.Load += new System.EventHandler(this.Control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBIMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamientoBindingNavigator)).EndInit();
            this.estacionamientoBindingNavigator.ResumeLayout(false);
            this.estacionamientoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamientoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBIMDataSet dBIMDataSet;
        private System.Windows.Forms.BindingSource estacionamientoBindingSource;
        private DBIMDataSetTableAdapters.EstacionamientoTableAdapter estacionamientoTableAdapter;
        private DBIMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator estacionamientoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton estacionamientoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox estacionamientoTextBox;
        private System.Windows.Forms.TextBox lugaresTextBox;
        private System.Windows.Forms.DataGridView estacionamientoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}