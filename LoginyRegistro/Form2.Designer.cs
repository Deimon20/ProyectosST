namespace Autenticacion
{
    partial class Form2
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
            this.cbox_req = new System.Windows.Forms.ComboBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_tipoReq = new System.Windows.Forms.Label();
            this.cbox_asignado = new System.Windows.Forms.ComboBox();
            this.lbl_asignado = new System.Windows.Forms.Label();
            this.tbox_descReq = new System.Windows.Forms.TextBox();
            this.lbl_descReq = new System.Windows.Forms.Label();
            this.lbl_prioridad = new System.Windows.Forms.Label();
            this.cbox_prioridad = new System.Windows.Forms.ComboBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbox_req
            // 
            this.cbox_req.FormattingEnabled = true;
            this.cbox_req.Items.AddRange(new object[] {
            "Base de Datos",
            "Sistema",
            "Servidor"});
            this.cbox_req.Location = new System.Drawing.Point(212, 88);
            this.cbox_req.Name = "cbox_req";
            this.cbox_req.Size = new System.Drawing.Size(213, 23);
            this.cbox_req.TabIndex = 0;
            this.cbox_req.Text = "Seleccionar...";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_titulo.Location = new System.Drawing.Point(88, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(293, 28);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "Registro de Requerimientos";
            // 
            // lbl_tipoReq
            // 
            this.lbl_tipoReq.AutoSize = true;
            this.lbl_tipoReq.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_tipoReq.Location = new System.Drawing.Point(12, 88);
            this.lbl_tipoReq.Name = "lbl_tipoReq";
            this.lbl_tipoReq.Size = new System.Drawing.Size(184, 21);
            this.lbl_tipoReq.TabIndex = 2;
            this.lbl_tipoReq.Text = "Tipo de Requerimiento";
            // 
            // cbox_asignado
            // 
            this.cbox_asignado.FormattingEnabled = true;
            this.cbox_asignado.Items.AddRange(new object[] {
            "Pepe Tapia",
            "Pepe Gamer",
            "Pepe Deus",
            "Pepe Nuv",
            "Pepe Simp",
            "pgamer",
            "dsalinas"});
            this.cbox_asignado.Location = new System.Drawing.Point(212, 136);
            this.cbox_asignado.Name = "cbox_asignado";
            this.cbox_asignado.Size = new System.Drawing.Size(213, 23);
            this.cbox_asignado.TabIndex = 3;
            this.cbox_asignado.Text = "Seleccionar...";
            // 
            // lbl_asignado
            // 
            this.lbl_asignado.AutoSize = true;
            this.lbl_asignado.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_asignado.Location = new System.Drawing.Point(12, 138);
            this.lbl_asignado.Name = "lbl_asignado";
            this.lbl_asignado.Size = new System.Drawing.Size(97, 21);
            this.lbl_asignado.TabIndex = 4;
            this.lbl_asignado.Text = "Asignado A";
            // 
            // tbox_descReq
            // 
            this.tbox_descReq.Location = new System.Drawing.Point(53, 231);
            this.tbox_descReq.Multiline = true;
            this.tbox_descReq.Name = "tbox_descReq";
            this.tbox_descReq.Size = new System.Drawing.Size(372, 84);
            this.tbox_descReq.TabIndex = 5;
            // 
            // lbl_descReq
            // 
            this.lbl_descReq.AutoSize = true;
            this.lbl_descReq.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_descReq.Location = new System.Drawing.Point(12, 207);
            this.lbl_descReq.Name = "lbl_descReq";
            this.lbl_descReq.Size = new System.Drawing.Size(239, 21);
            this.lbl_descReq.TabIndex = 6;
            this.lbl_descReq.Text = "Descripción de Requerimiento";
            // 
            // lbl_prioridad
            // 
            this.lbl_prioridad.AutoSize = true;
            this.lbl_prioridad.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_prioridad.Location = new System.Drawing.Point(12, 349);
            this.lbl_prioridad.Name = "lbl_prioridad";
            this.lbl_prioridad.Size = new System.Drawing.Size(79, 21);
            this.lbl_prioridad.TabIndex = 7;
            this.lbl_prioridad.Text = "Prioridad";
            // 
            // cbox_prioridad
            // 
            this.cbox_prioridad.FormattingEnabled = true;
            this.cbox_prioridad.Items.AddRange(new object[] {
            "Alta",
            "Media",
            "Baja"});
            this.cbox_prioridad.Location = new System.Drawing.Point(212, 347);
            this.cbox_prioridad.Name = "cbox_prioridad";
            this.cbox_prioridad.Size = new System.Drawing.Size(213, 23);
            this.cbox_prioridad.TabIndex = 8;
            this.cbox_prioridad.Text = "Seleccionar...";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(350, 404);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 9;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 450);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.cbox_prioridad);
            this.Controls.Add(this.lbl_prioridad);
            this.Controls.Add(this.lbl_descReq);
            this.Controls.Add(this.tbox_descReq);
            this.Controls.Add(this.lbl_asignado);
            this.Controls.Add(this.cbox_asignado);
            this.Controls.Add(this.lbl_tipoReq);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.cbox_req);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbox_req;
        private Label lbl_titulo;
        private Label lbl_tipoReq;
        private ComboBox cbox_asignado;
        private Label lbl_asignado;
        private TextBox tbox_descReq;
        private Label lbl_descReq;
        private Label lbl_prioridad;
        private ComboBox cbox_prioridad;
        private Button btn_guardar;
    }
}