namespace Interfaz_gráfica
{
    partial class Administrador
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
            System.Windows.Forms.Label foto_VeiculoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
            this.registroBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.registroDataGridView = new System.Windows.Forms.DataGridView();
            this.estacionamientoDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.foto_VeiculoPictureBox = new System.Windows.Forms.PictureBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.registroBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estacionamientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBIMDataSet = new Interfaz_gráfica.DBIMDataSet();
            this.registroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registroTableAdapter = new Interfaz_gráfica.DBIMDataSetTableAdapters.RegistroTableAdapter();
            this.tableAdapterManager = new Interfaz_gráfica.DBIMDataSetTableAdapters.TableAdapterManager();
            this.estacionamientoTableAdapter = new Interfaz_gráfica.DBIMDataSetTableAdapters.EstacionamientoTableAdapter();
            foto_VeiculoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.registroBindingNavigator)).BeginInit();
            this.registroBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registroDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamientoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto_VeiculoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBIMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // registroBindingNavigator
            // 
            this.registroBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.registroBindingNavigator.BindingSource = this.registroBindingSource;
            this.registroBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.registroBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.registroBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.registroBindingNavigatorSaveItem});
            this.registroBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.registroBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.registroBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.registroBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.registroBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.registroBindingNavigator.Name = "registroBindingNavigator";
            this.registroBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.registroBindingNavigator.Size = new System.Drawing.Size(906, 25);
            this.registroBindingNavigator.TabIndex = 4;
            this.registroBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // registroDataGridView
            // 
            this.registroDataGridView.AutoGenerateColumns = false;
            this.registroDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registroDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.registroDataGridView.DataSource = this.registroBindingSource;
            this.registroDataGridView.Location = new System.Drawing.Point(12, 228);
            this.registroDataGridView.Name = "registroDataGridView";
            this.registroDataGridView.Size = new System.Drawing.Size(445, 220);
            this.registroDataGridView.TabIndex = 4;
            // 
            // foto_VeiculoLabel
            // 
            foto_VeiculoLabel.AutoSize = true;
            foto_VeiculoLabel.Location = new System.Drawing.Point(180, 55);
            foto_VeiculoLabel.Name = "foto_VeiculoLabel";
            foto_VeiculoLabel.Size = new System.Drawing.Size(69, 13);
            foto_VeiculoLabel.TabIndex = 4;
            foto_VeiculoLabel.Text = "Foto Veiculo:";
            // 
            // estacionamientoDataGridView
            // 
            this.estacionamientoDataGridView.AutoGenerateColumns = false;
            this.estacionamientoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.estacionamientoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.estacionamientoDataGridView.DataSource = this.estacionamientoBindingSource;
            this.estacionamientoDataGridView.Location = new System.Drawing.Point(570, 12);
            this.estacionamientoDataGridView.Name = "estacionamientoDataGridView";
            this.estacionamientoDataGridView.Size = new System.Drawing.Size(244, 220);
            this.estacionamientoDataGridView.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(894, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(12, 10);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // foto_VeiculoPictureBox
            // 
            this.foto_VeiculoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.registroBindingSource, "Foto_Veiculo", true));
            this.foto_VeiculoPictureBox.Location = new System.Drawing.Point(93, 71);
            this.foto_VeiculoPictureBox.Name = "foto_VeiculoPictureBox";
            this.foto_VeiculoPictureBox.Size = new System.Drawing.Size(260, 151);
            this.foto_VeiculoPictureBox.TabIndex = 5;
            this.foto_VeiculoPictureBox.TabStop = false;
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
            // registroBindingNavigatorSaveItem
            // 
            this.registroBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.registroBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("registroBindingNavigatorSaveItem.Image")));
            this.registroBindingNavigatorSaveItem.Name = "registroBindingNavigatorSaveItem";
            this.registroBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.registroBindingNavigatorSaveItem.Text = "Guardar datos";
            this.registroBindingNavigatorSaveItem.Click += new System.EventHandler(this.registroBindingNavigatorSaveItem_Click);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Estacionamiento";
            this.dataGridViewTextBoxColumn4.HeaderText = "Estacionamiento";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Lugares";
            this.dataGridViewTextBoxColumn5.HeaderText = "Lugares";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // estacionamientoBindingSource
            // 
            this.estacionamientoBindingSource.DataMember = "Estacionamiento";
            this.estacionamientoBindingSource.DataSource = this.dBIMDataSet;
            // 
            // dBIMDataSet
            // 
            this.dBIMDataSet.DataSetName = "DBIMDataSet";
            this.dBIMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registroBindingSource
            // 
            this.registroBindingSource.DataMember = "Registro";
            this.registroBindingSource.DataSource = this.dBIMDataSet;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Foto_Veiculo";
            this.dataGridViewImageColumn1.HeaderText = "Foto_Veiculo";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Entrada";
            this.dataGridViewTextBoxColumn2.HeaderText = "Entrada";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Salida";
            this.dataGridViewTextBoxColumn3.HeaderText = "Salida";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // registroTableAdapter
            // 
            this.registroTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EstacionamientoTableAdapter = this.estacionamientoTableAdapter;
            this.tableAdapterManager.RegistroTableAdapter = this.registroTableAdapter;
            this.tableAdapterManager.UpdateOrder = Interfaz_gráfica.DBIMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // estacionamientoTableAdapter
            // 
            this.estacionamientoTableAdapter.ClearBeforeFill = true;
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 518);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.estacionamientoDataGridView);
            this.Controls.Add(foto_VeiculoLabel);
            this.Controls.Add(this.foto_VeiculoPictureBox);
            this.Controls.Add(this.registroDataGridView);
            this.Controls.Add(this.registroBindingNavigator);
            this.Name = "Administrador";
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.Administrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registroBindingNavigator)).EndInit();
            this.registroBindingNavigator.ResumeLayout(false);
            this.registroBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registroDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamientoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto_VeiculoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBIMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DBIMDataSet dBIMDataSet;
        private System.Windows.Forms.BindingSource registroBindingSource;
        private DBIMDataSetTableAdapters.RegistroTableAdapter registroTableAdapter;
        private DBIMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator registroBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton registroBindingNavigatorSaveItem;
        private DBIMDataSetTableAdapters.EstacionamientoTableAdapter estacionamientoTableAdapter;
        private System.Windows.Forms.DataGridView registroDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.PictureBox foto_VeiculoPictureBox;
        private System.Windows.Forms.BindingSource estacionamientoBindingSource;
        private System.Windows.Forms.DataGridView estacionamientoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button1;
    }
}