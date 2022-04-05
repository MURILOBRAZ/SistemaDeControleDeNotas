namespace TP08_202873
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxSerie = new System.Windows.Forms.TextBox();
            this.lblSerie = new System.Windows.Forms.Label();
            this.tbxMatricula = new System.Windows.Forms.TextBox();
            this.tbxDisciplina = new System.Windows.Forms.TextBox();
            this.gbxNotas = new System.Windows.Forms.GroupBox();
            this.tbx4Bi = new System.Windows.Forms.TextBox();
            this.lbl4Bi = new System.Windows.Forms.Label();
            this.tbx3Bi = new System.Windows.Forms.TextBox();
            this.lbl3Bi = new System.Windows.Forms.Label();
            this.tbx2Bi = new System.Windows.Forms.TextBox();
            this.lbl2Bi = new System.Windows.Forms.Label();
            this.tbx1Bi = new System.Windows.Forms.TextBox();
            this.lbl1Bi = new System.Windows.Forms.Label();
            this.lblMatri = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCad = new System.Windows.Forms.Button();
            this.tbxConceito = new System.Windows.Forms.TextBox();
            this.tbxMfinal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMfinal = new System.Windows.Forms.Label();
            this.dtsControle = new System.Data.DataSet();
            this.dtbControle = new System.Data.DataTable();
            this.dtcNome = new System.Data.DataColumn();
            this.dtcSerie = new System.Data.DataColumn();
            this.dtcMatricula = new System.Data.DataColumn();
            this.dtcNota1 = new System.Data.DataColumn();
            this.dtcNota2 = new System.Data.DataColumn();
            this.dtcNota3 = new System.Data.DataColumn();
            this.dtcNota4 = new System.Data.DataColumn();
            this.dtcMedia = new System.Data.DataColumn();
            this.dtcConceito = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dtgControle = new System.Windows.Forms.DataGridView();
            this.bscControle = new System.Windows.Forms.BindingSource(this.components);
            this.lblProcu = new System.Windows.Forms.Label();
            this.cbxProcurar = new System.Windows.Forms.ComboBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.tbxFiltro = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLinha = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuColuna = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.nomeDaDisciplinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sérieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matrículaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.médiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conceitoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.gbxNotas.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtsControle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtbControle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgControle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bscControle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tbxSerie);
            this.panel1.Controls.Add(this.lblSerie);
            this.panel1.Controls.Add(this.tbxMatricula);
            this.panel1.Controls.Add(this.tbxDisciplina);
            this.panel1.Controls.Add(this.gbxNotas);
            this.panel1.Controls.Add(this.lblMatri);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Location = new System.Drawing.Point(12, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 186);
            this.panel1.TabIndex = 0;
            // 
            // tbxSerie
            // 
            this.tbxSerie.Location = new System.Drawing.Point(564, 18);
            this.tbxSerie.MaxLength = 1;
            this.tbxSerie.Name = "tbxSerie";
            this.tbxSerie.Size = new System.Drawing.Size(91, 20);
            this.tbxSerie.TabIndex = 10;
            this.tbxSerie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx1Bi_KeyPress);
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("Harry P", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.Location = new System.Drawing.Point(497, 11);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(61, 27);
            this.lblSerie.TabIndex = 5;
            this.lblSerie.Text = "Série:";
            // 
            // tbxMatricula
            // 
            this.tbxMatricula.Location = new System.Drawing.Point(273, 48);
            this.tbxMatricula.MaxLength = 6;
            this.tbxMatricula.Name = "tbxMatricula";
            this.tbxMatricula.Size = new System.Drawing.Size(121, 20);
            this.tbxMatricula.TabIndex = 4;
            this.tbxMatricula.TextChanged += new System.EventHandler(this.tbxMatricula_TextChanged);
            this.tbxMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx1Bi_KeyPress);
            // 
            // tbxDisciplina
            // 
            this.tbxDisciplina.Location = new System.Drawing.Point(181, 16);
            this.tbxDisciplina.Name = "tbxDisciplina";
            this.tbxDisciplina.Size = new System.Drawing.Size(193, 20);
            this.tbxDisciplina.TabIndex = 3;
            this.tbxDisciplina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxDisciplina_KeyPress);
            // 
            // gbxNotas
            // 
            this.gbxNotas.Controls.Add(this.tbx4Bi);
            this.gbxNotas.Controls.Add(this.lbl4Bi);
            this.gbxNotas.Controls.Add(this.tbx3Bi);
            this.gbxNotas.Controls.Add(this.lbl3Bi);
            this.gbxNotas.Controls.Add(this.tbx2Bi);
            this.gbxNotas.Controls.Add(this.lbl2Bi);
            this.gbxNotas.Controls.Add(this.tbx1Bi);
            this.gbxNotas.Controls.Add(this.lbl1Bi);
            this.gbxNotas.Font = new System.Drawing.Font("Harry P", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxNotas.Location = new System.Drawing.Point(11, 84);
            this.gbxNotas.Name = "gbxNotas";
            this.gbxNotas.Size = new System.Drawing.Size(652, 88);
            this.gbxNotas.TabIndex = 2;
            this.gbxNotas.TabStop = false;
            this.gbxNotas.Text = "Notas:";
            // 
            // tbx4Bi
            // 
            this.tbx4Bi.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx4Bi.Location = new System.Drawing.Point(599, 33);
            this.tbx4Bi.MaxLength = 3;
            this.tbx4Bi.Name = "tbx4Bi";
            this.tbx4Bi.Size = new System.Drawing.Size(34, 35);
            this.tbx4Bi.TabIndex = 11;
            this.tbx4Bi.TextChanged += new System.EventHandler(this.tbx4Bi_TextChanged);
            this.tbx4Bi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx1Bi_KeyPress);
            // 
            // lbl4Bi
            // 
            this.lbl4Bi.AutoSize = true;
            this.lbl4Bi.Font = new System.Drawing.Font("Harry P", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Bi.Location = new System.Drawing.Point(501, 41);
            this.lbl4Bi.Name = "lbl4Bi";
            this.lbl4Bi.Size = new System.Drawing.Size(92, 24);
            this.lbl4Bi.TabIndex = 10;
            this.lbl4Bi.Text = "4°Bimestre:";
            // 
            // tbx3Bi
            // 
            this.tbx3Bi.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx3Bi.Location = new System.Drawing.Point(433, 33);
            this.tbx3Bi.MaxLength = 3;
            this.tbx3Bi.Name = "tbx3Bi";
            this.tbx3Bi.Size = new System.Drawing.Size(34, 35);
            this.tbx3Bi.TabIndex = 9;
            this.tbx3Bi.TextChanged += new System.EventHandler(this.tbx3Bi_TextChanged);
            this.tbx3Bi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx1Bi_KeyPress);
            // 
            // lbl3Bi
            // 
            this.lbl3Bi.AutoSize = true;
            this.lbl3Bi.Font = new System.Drawing.Font("Harry P", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Bi.Location = new System.Drawing.Point(338, 40);
            this.lbl3Bi.Name = "lbl3Bi";
            this.lbl3Bi.Size = new System.Drawing.Size(89, 24);
            this.lbl3Bi.TabIndex = 8;
            this.lbl3Bi.Text = "3°Bimestre:";
            // 
            // tbx2Bi
            // 
            this.tbx2Bi.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx2Bi.Location = new System.Drawing.Point(264, 33);
            this.tbx2Bi.MaxLength = 3;
            this.tbx2Bi.Name = "tbx2Bi";
            this.tbx2Bi.Size = new System.Drawing.Size(34, 35);
            this.tbx2Bi.TabIndex = 7;
            this.tbx2Bi.TextChanged += new System.EventHandler(this.tbx2Bi_TextChanged);
            this.tbx2Bi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx1Bi_KeyPress);
            // 
            // lbl2Bi
            // 
            this.lbl2Bi.AutoSize = true;
            this.lbl2Bi.Font = new System.Drawing.Font("Harry P", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Bi.Location = new System.Drawing.Point(168, 41);
            this.lbl2Bi.Name = "lbl2Bi";
            this.lbl2Bi.Size = new System.Drawing.Size(90, 24);
            this.lbl2Bi.TabIndex = 6;
            this.lbl2Bi.Text = "2°Bimestre:";
            // 
            // tbx1Bi
            // 
            this.tbx1Bi.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx1Bi.Location = new System.Drawing.Point(102, 34);
            this.tbx1Bi.MaxLength = 3;
            this.tbx1Bi.Name = "tbx1Bi";
            this.tbx1Bi.Size = new System.Drawing.Size(34, 35);
            this.tbx1Bi.TabIndex = 5;
            this.tbx1Bi.TextChanged += new System.EventHandler(this.tbx1Bi_TextChanged);
            this.tbx1Bi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx1Bi_KeyPress);
            // 
            // lbl1Bi
            // 
            this.lbl1Bi.AutoSize = true;
            this.lbl1Bi.Font = new System.Drawing.Font("Harry P", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Bi.Location = new System.Drawing.Point(10, 40);
            this.lbl1Bi.Name = "lbl1Bi";
            this.lbl1Bi.Size = new System.Drawing.Size(86, 24);
            this.lbl1Bi.TabIndex = 0;
            this.lbl1Bi.Text = "1°Bimestre:";
            // 
            // lblMatri
            // 
            this.lblMatri.AutoSize = true;
            this.lblMatri.Font = new System.Drawing.Font("Harry P", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatri.Location = new System.Drawing.Point(8, 41);
            this.lblMatri.Name = "lblMatri";
            this.lblMatri.Size = new System.Drawing.Size(259, 27);
            this.lblMatri.TabIndex = 1;
            this.lblMatri.Text = "Número de Matrícula do Aluno:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Harry P", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(8, 12);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(167, 27);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome da Disciplina:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnCad);
            this.panel2.Controls.Add(this.tbxConceito);
            this.panel2.Controls.Add(this.tbxMfinal);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblMfinal);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(700, 370);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 186);
            this.panel2.TabIndex = 1;
            // 
            // btnCad
            // 
            this.btnCad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCad.Font = new System.Drawing.Font("Harry P", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCad.Image = global::TP08_202873.Properties.Resources._86500456343;
            this.btnCad.Location = new System.Drawing.Point(60, 124);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(148, 55);
            this.btnCad.TabIndex = 4;
            this.btnCad.Text = "Cadastro";
            this.btnCad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // tbxConceito
            // 
            this.tbxConceito.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxConceito.Location = new System.Drawing.Point(145, 81);
            this.tbxConceito.Name = "tbxConceito";
            this.tbxConceito.Size = new System.Drawing.Size(100, 26);
            this.tbxConceito.TabIndex = 3;
            // 
            // tbxMfinal
            // 
            this.tbxMfinal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMfinal.Location = new System.Drawing.Point(145, 23);
            this.tbxMfinal.Name = "tbxMfinal";
            this.tbxMfinal.Size = new System.Drawing.Size(100, 26);
            this.tbxMfinal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harry P", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Conceito:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMfinal
            // 
            this.lblMfinal.AutoSize = true;
            this.lblMfinal.Font = new System.Drawing.Font("Harry P", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMfinal.Location = new System.Drawing.Point(24, 20);
            this.lblMfinal.Name = "lblMfinal";
            this.lblMfinal.Size = new System.Drawing.Size(115, 27);
            this.lblMfinal.TabIndex = 0;
            this.lblMfinal.Text = "Média Final:";
            // 
            // dtsControle
            // 
            this.dtsControle.DataSetName = "Controle";
            this.dtsControle.Tables.AddRange(new System.Data.DataTable[] {
            this.dtbControle});
            // 
            // dtbControle
            // 
            this.dtbControle.Columns.AddRange(new System.Data.DataColumn[] {
            this.dtcNome,
            this.dtcSerie,
            this.dtcMatricula,
            this.dtcNota1,
            this.dtcNota2,
            this.dtcNota3,
            this.dtcNota4,
            this.dtcMedia,
            this.dtcConceito,
            this.dataColumn1});
            this.dtbControle.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "indice"}, false)});
            this.dtbControle.TableName = "ControleTab";
            // 
            // dtcNome
            // 
            this.dtcNome.Caption = "Disciplina";
            this.dtcNome.ColumnName = "Disciplina";
            // 
            // dtcSerie
            // 
            this.dtcSerie.Caption = "Série";
            this.dtcSerie.ColumnName = "Série";
            // 
            // dtcMatricula
            // 
            this.dtcMatricula.Caption = "Matrícula";
            this.dtcMatricula.ColumnName = "Matrícula";
            // 
            // dtcNota1
            // 
            this.dtcNota1.Caption = "Nota1";
            this.dtcNota1.ColumnName = "Nota1";
            // 
            // dtcNota2
            // 
            this.dtcNota2.Caption = "Nota2";
            this.dtcNota2.ColumnName = "Nota2";
            // 
            // dtcNota3
            // 
            this.dtcNota3.Caption = "Nota3";
            this.dtcNota3.ColumnName = "Nota3";
            // 
            // dtcNota4
            // 
            this.dtcNota4.Caption = "Nota4";
            this.dtcNota4.ColumnName = "Nota4";
            // 
            // dtcMedia
            // 
            this.dtcMedia.Caption = "Média";
            this.dtcMedia.ColumnName = "Média";
            // 
            // dtcConceito
            // 
            this.dtcConceito.Caption = "Conceito";
            this.dtcConceito.ColumnName = "Conceito";
            // 
            // dataColumn1
            // 
            this.dataColumn1.AutoIncrement = true;
            this.dataColumn1.Caption = "indice";
            this.dataColumn1.ColumnName = "indice";
            this.dataColumn1.DataType = typeof(int);
            // 
            // dtgControle
            // 
            this.dtgControle.AutoGenerateColumns = false;
            this.dtgControle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(148)))));
            this.dtgControle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgControle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDaDisciplinaDataGridViewTextBoxColumn,
            this.sérieDataGridViewTextBoxColumn,
            this.matrículaDataGridViewTextBoxColumn,
            this.Nota1,
            this.Nota2,
            this.Nota3,
            this.Nota4,
            this.médiaDataGridViewTextBoxColumn,
            this.conceitoDataGridViewTextBoxColumn});
            this.dtgControle.DataSource = this.bscControle;
            this.dtgControle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(148)))));
            this.dtgControle.Location = new System.Drawing.Point(25, 591);
            this.dtgControle.Name = "dtgControle";
            this.dtgControle.Size = new System.Drawing.Size(945, 180);
            this.dtgControle.TabIndex = 2;
            // 
            // bscControle
            // 
            this.bscControle.DataMember = "ControleTab";
            this.bscControle.DataSource = this.dtsControle;
            // 
            // lblProcu
            // 
            this.lblProcu.AutoSize = true;
            this.lblProcu.BackColor = System.Drawing.Color.Transparent;
            this.lblProcu.Font = new System.Drawing.Font("Harry P", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcu.Location = new System.Drawing.Point(564, 561);
            this.lblProcu.Name = "lblProcu";
            this.lblProcu.Size = new System.Drawing.Size(113, 27);
            this.lblProcu.TabIndex = 3;
            this.lblProcu.Text = "Procurar Por:";
            // 
            // cbxProcurar
            // 
            this.cbxProcurar.FormattingEnabled = true;
            this.cbxProcurar.Items.AddRange(new object[] {
            "Disciplina",
            "Série",
            "Matrícula",
            "Conceito"});
            this.cbxProcurar.Location = new System.Drawing.Point(677, 562);
            this.cbxProcurar.Name = "cbxProcurar";
            this.cbxProcurar.Size = new System.Drawing.Size(121, 21);
            this.cbxProcurar.TabIndex = 4;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltro.Font = new System.Drawing.Font("Harry P", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(816, 559);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(57, 27);
            this.lblFiltro.TabIndex = 5;
            this.lblFiltro.Text = "Filtro:";
            // 
            // tbxFiltro
            // 
            this.tbxFiltro.Location = new System.Drawing.Point(870, 562);
            this.tbxFiltro.Name = "tbxFiltro";
            this.tbxFiltro.Size = new System.Drawing.Size(100, 20);
            this.tbxFiltro.TabIndex = 6;
            this.tbxFiltro.TextChanged += new System.EventHandler(this.tbxFiltro_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::TP08_202873.Properties.Resources.Untitled_43546;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(395, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 157);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::TP08_202873.Properties.Resources.pngegg__2_11;
            this.pictureBox2.Location = new System.Drawing.Point(588, 170);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(359, 219);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::TP08_202873.Properties.Resources.pngegg__2_;
            this.pictureBox3.Location = new System.Drawing.Point(414, 349);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(280, 207);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::TP08_202873.Properties.Resources.sova_garri_pottera_kak_ee_zvali_21;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(45, 349);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(363, 263);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(989, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linhaToolStripMenuItem});
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.exportarToolStripMenuItem.Text = "Exportar";
            // 
            // linhaToolStripMenuItem
            // 
            this.linhaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuLinha,
            this.MenuColuna});
            this.linhaToolStripMenuItem.Name = "linhaToolStripMenuItem";
            this.linhaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.linhaToolStripMenuItem.Text = "Texto";
            // 
            // MenuLinha
            // 
            this.MenuLinha.Name = "MenuLinha";
            this.MenuLinha.Size = new System.Drawing.Size(180, 22);
            this.MenuLinha.Text = "Linha";
            this.MenuLinha.Click += new System.EventHandler(this.MenuLinha_Click);
            // 
            // MenuColuna
            // 
            this.MenuColuna.Name = "MenuColuna";
            this.MenuColuna.Size = new System.Drawing.Size(180, 22);
            this.MenuColuna.Text = "Coluna";
            this.MenuColuna.Click += new System.EventHandler(this.MenuColuna_Click);
            // 
            // nomeDaDisciplinaDataGridViewTextBoxColumn
            // 
            this.nomeDaDisciplinaDataGridViewTextBoxColumn.DataPropertyName = "Disciplina";
            this.nomeDaDisciplinaDataGridViewTextBoxColumn.HeaderText = "Disciplina";
            this.nomeDaDisciplinaDataGridViewTextBoxColumn.Name = "nomeDaDisciplinaDataGridViewTextBoxColumn";
            // 
            // sérieDataGridViewTextBoxColumn
            // 
            this.sérieDataGridViewTextBoxColumn.DataPropertyName = "Série";
            this.sérieDataGridViewTextBoxColumn.HeaderText = "Série";
            this.sérieDataGridViewTextBoxColumn.Name = "sérieDataGridViewTextBoxColumn";
            // 
            // matrículaDataGridViewTextBoxColumn
            // 
            this.matrículaDataGridViewTextBoxColumn.DataPropertyName = "Matrícula";
            this.matrículaDataGridViewTextBoxColumn.HeaderText = "Matrícula";
            this.matrículaDataGridViewTextBoxColumn.Name = "matrículaDataGridViewTextBoxColumn";
            // 
            // Nota1
            // 
            this.Nota1.DataPropertyName = "Nota1";
            this.Nota1.HeaderText = "Nota 1°Bimestre";
            this.Nota1.Name = "Nota1";
            // 
            // Nota2
            // 
            this.Nota2.DataPropertyName = "Nota2";
            this.Nota2.HeaderText = "Nota 2°Bimestre";
            this.Nota2.Name = "Nota2";
            // 
            // Nota3
            // 
            this.Nota3.DataPropertyName = "Nota3";
            this.Nota3.HeaderText = "Nota 3°Bimestre";
            this.Nota3.Name = "Nota3";
            // 
            // Nota4
            // 
            this.Nota4.DataPropertyName = "Nota4";
            this.Nota4.HeaderText = "Nota 4°Bimestre";
            this.Nota4.Name = "Nota4";
            // 
            // médiaDataGridViewTextBoxColumn
            // 
            this.médiaDataGridViewTextBoxColumn.DataPropertyName = "Média";
            this.médiaDataGridViewTextBoxColumn.HeaderText = "Média";
            this.médiaDataGridViewTextBoxColumn.Name = "médiaDataGridViewTextBoxColumn";
            // 
            // conceitoDataGridViewTextBoxColumn
            // 
            this.conceitoDataGridViewTextBoxColumn.DataPropertyName = "Conceito";
            this.conceitoDataGridViewTextBoxColumn.HeaderText = "Conceito";
            this.conceitoDataGridViewTextBoxColumn.Name = "conceitoDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::TP08_202873.Properties.Resources.vintage_1659118;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(989, 780);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbxFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.cbxProcurar);
            this.Controls.Add(this.lblProcu);
            this.Controls.Add(this.dtgControle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Controle de Notas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbxNotas.ResumeLayout(false);
            this.gbxNotas.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtsControle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtbControle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgControle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bscControle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxSerie;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.TextBox tbxMatricula;
        private System.Windows.Forms.TextBox tbxDisciplina;
        private System.Windows.Forms.GroupBox gbxNotas;
        private System.Windows.Forms.TextBox tbx4Bi;
        private System.Windows.Forms.Label lbl4Bi;
        private System.Windows.Forms.TextBox tbx3Bi;
        private System.Windows.Forms.Label lbl3Bi;
        private System.Windows.Forms.TextBox tbx2Bi;
        private System.Windows.Forms.Label lbl2Bi;
        private System.Windows.Forms.TextBox tbx1Bi;
        private System.Windows.Forms.Label lbl1Bi;
        private System.Windows.Forms.Label lblMatri;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMfinal;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.TextBox tbxConceito;
        private System.Windows.Forms.TextBox tbxMfinal;
        private System.Data.DataSet dtsControle;
        private System.Data.DataTable dtbControle;
        private System.Data.DataColumn dtcNome;
        private System.Data.DataColumn dtcSerie;
        private System.Data.DataColumn dtcMatricula;
        private System.Data.DataColumn dtcNota1;
        private System.Data.DataColumn dtcNota2;
        private System.Data.DataColumn dtcNota3;
        private System.Data.DataColumn dtcNota4;
        private System.Data.DataColumn dtcMedia;
        private System.Data.DataColumn dtcConceito;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.DataGridView dtgControle;
        private System.Windows.Forms.BindingSource bscControle;
        private System.Windows.Forms.Label lblProcu;
        private System.Windows.Forms.ComboBox cbxProcurar;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox tbxFiltro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuLinha;
        private System.Windows.Forms.ToolStripMenuItem MenuColuna;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDaDisciplinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sérieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matrículaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota4;
        private System.Windows.Forms.DataGridViewTextBoxColumn médiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conceitoDataGridViewTextBoxColumn;
    }
}

