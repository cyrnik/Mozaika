namespace Bikina
{
    partial class Form3
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
            System.Windows.Forms.Label iD_ПродукцииLabel;
            System.Windows.Forms.Label артикулLabel;
            System.Windows.Forms.Label iD_Типа_ПродукцииLabel;
            System.Windows.Forms.Label наименованиеLabel;
            System.Windows.Forms.Label описаниеLabel;
            System.Windows.Forms.Label изображениеLabel;
            System.Windows.Forms.Label минимальная_стоимость_для_партнераLabel;
            System.Windows.Forms.Label длина_упаковкиLabel;
            System.Windows.Forms.Label ширина_упаковкиLabel;
            System.Windows.Forms.Label высота_упаковкиLabel;
            System.Windows.Forms.Label вес_без_упаковкиLabel;
            System.Windows.Forms.Label вес_с_упаковкойLabel;
            System.Windows.Forms.Label сертификат_качестваLabel;
            System.Windows.Forms.Label номер_стандартаLabel;
            System.Windows.Forms.Label время_изготовленияLabel;
            System.Windows.Forms.Label себестоимостьLabel;
            System.Windows.Forms.Label номер_цехаLabel;
            System.Windows.Forms.Label количество_человек_на_производствеLabel;
            System.Windows.Forms.Label iD_ИсторииLabel;
            System.Windows.Forms.Label iD_ПродукцииLabel1;
            System.Windows.Forms.Label предыдущая_ценаLabel;
            System.Windows.Forms.Label текущая_ценаLabel;
            System.Windows.Forms.Label дата_измененияLabel;
            System.Windows.Forms.Label iD_МенеджераLabel;
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label почтаLabel;
            System.Windows.Forms.Label iD_СотрудникаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.bikinaDataSet = new Bikina.BikinaDataSet();
            this.иСТОРИЯ_ЦЕНBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.иСТОРИЯ_ЦЕНTableAdapter = new Bikina.BikinaDataSetTableAdapters.ИСТОРИЯ_ЦЕНTableAdapter();
            this.tableAdapterManager = new Bikina.BikinaDataSetTableAdapters.TableAdapterManager();
            this.мЕНЕДЖЕРЫTableAdapter = new Bikina.BikinaDataSetTableAdapters.МЕНЕДЖЕРЫTableAdapter();
            this.пРОДУКЦИЯTableAdapter = new Bikina.BikinaDataSetTableAdapters.ПРОДУКЦИЯTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.дОСТУПBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.дОСТУПBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.количество_человек_на_производствеTextBox = new System.Windows.Forms.TextBox();
            this.пРОДУКЦИЯBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.номер_цехаTextBox = new System.Windows.Forms.TextBox();
            this.себестоимостьTextBox = new System.Windows.Forms.TextBox();
            this.время_изготовленияTextBox = new System.Windows.Forms.TextBox();
            this.номер_стандартаTextBox = new System.Windows.Forms.TextBox();
            this.сертификат_качестваTextBox = new System.Windows.Forms.TextBox();
            this.вес_с_упаковкойTextBox = new System.Windows.Forms.TextBox();
            this.вес_без_упаковкиTextBox = new System.Windows.Forms.TextBox();
            this.высота_упаковкиTextBox = new System.Windows.Forms.TextBox();
            this.ширина_упаковкиTextBox = new System.Windows.Forms.TextBox();
            this.длина_упаковкиTextBox = new System.Windows.Forms.TextBox();
            this.минимальная_стоимость_для_партнераTextBox = new System.Windows.Forms.TextBox();
            this.изображениеTextBox = new System.Windows.Forms.TextBox();
            this.описаниеTextBox = new System.Windows.Forms.TextBox();
            this.наименованиеTextBox = new System.Windows.Forms.TextBox();
            this.iD_Типа_ПродукцииTextBox = new System.Windows.Forms.TextBox();
            this.артикулTextBox = new System.Windows.Forms.TextBox();
            this.iD_ПродукцииTextBox = new System.Windows.Forms.TextBox();
            this.пРОДУКЦИЯDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.дата_измененияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.иСТОРИЯ_ЦЕНBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.текущая_ценаTextBox = new System.Windows.Forms.TextBox();
            this.предыдущая_ценаTextBox = new System.Windows.Forms.TextBox();
            this.iD_ПродукцииTextBox1 = new System.Windows.Forms.TextBox();
            this.iD_ИсторииTextBox = new System.Windows.Forms.TextBox();
            this.иСТОРИЯ_ЦЕНDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.iD_СотрудникаTextBox = new System.Windows.Forms.TextBox();
            this.мЕНЕДЖЕРЫBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.почтаTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.iD_МенеджераTextBox = new System.Windows.Forms.TextBox();
            this.мЕНЕДЖЕРЫDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iD_ПродукцииLabel = new System.Windows.Forms.Label();
            артикулLabel = new System.Windows.Forms.Label();
            iD_Типа_ПродукцииLabel = new System.Windows.Forms.Label();
            наименованиеLabel = new System.Windows.Forms.Label();
            описаниеLabel = new System.Windows.Forms.Label();
            изображениеLabel = new System.Windows.Forms.Label();
            минимальная_стоимость_для_партнераLabel = new System.Windows.Forms.Label();
            длина_упаковкиLabel = new System.Windows.Forms.Label();
            ширина_упаковкиLabel = new System.Windows.Forms.Label();
            высота_упаковкиLabel = new System.Windows.Forms.Label();
            вес_без_упаковкиLabel = new System.Windows.Forms.Label();
            вес_с_упаковкойLabel = new System.Windows.Forms.Label();
            сертификат_качестваLabel = new System.Windows.Forms.Label();
            номер_стандартаLabel = new System.Windows.Forms.Label();
            время_изготовленияLabel = new System.Windows.Forms.Label();
            себестоимостьLabel = new System.Windows.Forms.Label();
            номер_цехаLabel = new System.Windows.Forms.Label();
            количество_человек_на_производствеLabel = new System.Windows.Forms.Label();
            iD_ИсторииLabel = new System.Windows.Forms.Label();
            iD_ПродукцииLabel1 = new System.Windows.Forms.Label();
            предыдущая_ценаLabel = new System.Windows.Forms.Label();
            текущая_ценаLabel = new System.Windows.Forms.Label();
            дата_измененияLabel = new System.Windows.Forms.Label();
            iD_МенеджераLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            почтаLabel = new System.Windows.Forms.Label();
            iD_СотрудникаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bikinaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.иСТОРИЯ_ЦЕНBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.дОСТУПBindingNavigator)).BeginInit();
            this.дОСТУПBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.пРОДУКЦИЯBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пРОДУКЦИЯDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.иСТОРИЯ_ЦЕНBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.иСТОРИЯ_ЦЕНDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.мЕНЕДЖЕРЫBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мЕНЕДЖЕРЫDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_ПродукцииLabel
            // 
            iD_ПродукцииLabel.AutoSize = true;
            iD_ПродукцииLabel.Location = new System.Drawing.Point(128, 289);
            iD_ПродукцииLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            iD_ПродукцииLabel.Name = "iD_ПродукцииLabel";
            iD_ПродукцииLabel.Size = new System.Drawing.Size(99, 16);
            iD_ПродукцииLabel.TabIndex = 1;
            iD_ПродукцииLabel.Text = "ID Продукции:";
            // 
            // артикулLabel
            // 
            артикулLabel.AutoSize = true;
            артикулLabel.Location = new System.Drawing.Point(165, 321);
            артикулLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            артикулLabel.Name = "артикулLabel";
            артикулLabel.Size = new System.Drawing.Size(65, 16);
            артикулLabel.TabIndex = 3;
            артикулLabel.Text = "Артикул:";
            // 
            // iD_Типа_ПродукцииLabel
            // 
            iD_Типа_ПродукцииLabel.AutoSize = true;
            iD_Типа_ПродукцииLabel.Location = new System.Drawing.Point(91, 353);
            iD_Типа_ПродукцииLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            iD_Типа_ПродукцииLabel.Name = "iD_Типа_ПродукцииLabel";
            iD_Типа_ПродукцииLabel.Size = new System.Drawing.Size(135, 16);
            iD_Типа_ПродукцииLabel.TabIndex = 5;
            iD_Типа_ПродукцииLabel.Text = "ID Типа Продукции:";
            // 
            // наименованиеLabel
            // 
            наименованиеLabel.AutoSize = true;
            наименованиеLabel.Location = new System.Drawing.Point(119, 385);
            наименованиеLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            наименованиеLabel.Name = "наименованиеLabel";
            наименованиеLabel.Size = new System.Drawing.Size(109, 16);
            наименованиеLabel.TabIndex = 7;
            наименованиеLabel.Text = "Наименование:";
            // 
            // описаниеLabel
            // 
            описаниеLabel.AutoSize = true;
            описаниеLabel.Location = new System.Drawing.Point(153, 417);
            описаниеLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            описаниеLabel.Name = "описаниеLabel";
            описаниеLabel.Size = new System.Drawing.Size(75, 16);
            описаниеLabel.TabIndex = 9;
            описаниеLabel.Text = "Описание:";
            // 
            // изображениеLabel
            // 
            изображениеLabel.AutoSize = true;
            изображениеLabel.Location = new System.Drawing.Point(127, 449);
            изображениеLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            изображениеLabel.Name = "изображениеLabel";
            изображениеLabel.Size = new System.Drawing.Size(101, 16);
            изображениеLabel.TabIndex = 11;
            изображениеLabel.Text = "Изображение:";
            // 
            // минимальная_стоимость_для_партнераLabel
            // 
            минимальная_стоимость_для_партнераLabel.AutoSize = true;
            минимальная_стоимость_для_партнераLabel.Location = new System.Drawing.Point(396, 289);
            минимальная_стоимость_для_партнераLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            минимальная_стоимость_для_партнераLabel.Name = "минимальная_стоимость_для_партнераLabel";
            минимальная_стоимость_для_партнераLabel.Size = new System.Drawing.Size(263, 16);
            минимальная_стоимость_для_партнераLabel.TabIndex = 13;
            минимальная_стоимость_для_партнераLabel.Text = "Минимальная стоимость для партнера:";
            // 
            // длина_упаковкиLabel
            // 
            длина_упаковкиLabel.AutoSize = true;
            длина_упаковкиLabel.Location = new System.Drawing.Point(551, 321);
            длина_упаковкиLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            длина_упаковкиLabel.Name = "длина_упаковкиLabel";
            длина_упаковкиLabel.Size = new System.Drawing.Size(116, 16);
            длина_упаковкиLabel.TabIndex = 15;
            длина_упаковкиLabel.Text = "Длина упаковки:";
            // 
            // ширина_упаковкиLabel
            // 
            ширина_упаковкиLabel.AutoSize = true;
            ширина_упаковкиLabel.Location = new System.Drawing.Point(543, 353);
            ширина_упаковкиLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ширина_упаковкиLabel.Name = "ширина_упаковкиLabel";
            ширина_упаковкиLabel.Size = new System.Drawing.Size(126, 16);
            ширина_упаковкиLabel.TabIndex = 17;
            ширина_упаковкиLabel.Text = "Ширина упаковки:";
            // 
            // высота_упаковкиLabel
            // 
            высота_упаковкиLabel.AutoSize = true;
            высота_упаковкиLabel.Location = new System.Drawing.Point(544, 385);
            высота_упаковкиLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            высота_упаковкиLabel.Name = "высота_упаковкиLabel";
            высота_упаковкиLabel.Size = new System.Drawing.Size(123, 16);
            высота_упаковкиLabel.TabIndex = 19;
            высота_упаковкиLabel.Text = "Высота упаковки:";
            // 
            // вес_без_упаковкиLabel
            // 
            вес_без_упаковкиLabel.AutoSize = true;
            вес_без_упаковкиLabel.Location = new System.Drawing.Point(541, 417);
            вес_без_упаковкиLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            вес_без_упаковкиLabel.Name = "вес_без_упаковкиLabel";
            вес_без_упаковкиLabel.Size = new System.Drawing.Size(126, 16);
            вес_без_упаковкиLabel.TabIndex = 21;
            вес_без_упаковкиLabel.Text = "Вес без упаковки:";
            // 
            // вес_с_упаковкойLabel
            // 
            вес_с_упаковкойLabel.AutoSize = true;
            вес_с_упаковкойLabel.Location = new System.Drawing.Point(549, 449);
            вес_с_упаковкойLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            вес_с_упаковкойLabel.Name = "вес_с_упаковкойLabel";
            вес_с_упаковкойLabel.Size = new System.Drawing.Size(117, 16);
            вес_с_упаковкойLabel.TabIndex = 23;
            вес_с_упаковкойLabel.Text = "Вес с упаковкой:";
            // 
            // сертификат_качестваLabel
            // 
            сертификат_качестваLabel.AutoSize = true;
            сертификат_качестваLabel.Location = new System.Drawing.Point(945, 294);
            сертификат_качестваLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            сертификат_качестваLabel.Name = "сертификат_качестваLabel";
            сертификат_качестваLabel.Size = new System.Drawing.Size(155, 16);
            сертификат_качестваLabel.TabIndex = 25;
            сертификат_качестваLabel.Text = "Сертификат качества:";
            // 
            // номер_стандартаLabel
            // 
            номер_стандартаLabel.AutoSize = true;
            номер_стандартаLabel.Location = new System.Drawing.Point(973, 326);
            номер_стандартаLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            номер_стандартаLabel.Name = "номер_стандартаLabel";
            номер_стандартаLabel.Size = new System.Drawing.Size(125, 16);
            номер_стандартаLabel.TabIndex = 27;
            номер_стандартаLabel.Text = "Номер стандарта:";
            // 
            // время_изготовленияLabel
            // 
            время_изготовленияLabel.AutoSize = true;
            время_изготовленияLabel.Location = new System.Drawing.Point(951, 358);
            время_изготовленияLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            время_изготовленияLabel.Name = "время_изготовленияLabel";
            время_изготовленияLabel.Size = new System.Drawing.Size(146, 16);
            время_изготовленияLabel.TabIndex = 29;
            время_изготовленияLabel.Text = "Время изготовления:";
            // 
            // себестоимостьLabel
            // 
            себестоимостьLabel.AutoSize = true;
            себестоимостьLabel.Location = new System.Drawing.Point(987, 390);
            себестоимостьLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            себестоимостьLabel.Name = "себестоимостьLabel";
            себестоимостьLabel.Size = new System.Drawing.Size(111, 16);
            себестоимостьLabel.TabIndex = 31;
            себестоимостьLabel.Text = "Себестоимость:";
            // 
            // номер_цехаLabel
            // 
            номер_цехаLabel.AutoSize = true;
            номер_цехаLabel.Location = new System.Drawing.Point(1012, 422);
            номер_цехаLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            номер_цехаLabel.Name = "номер_цехаLabel";
            номер_цехаLabel.Size = new System.Drawing.Size(86, 16);
            номер_цехаLabel.TabIndex = 33;
            номер_цехаLabel.Text = "Номер цеха:";
            // 
            // количество_человек_на_производствеLabel
            // 
            количество_человек_на_производствеLabel.AutoSize = true;
            количество_человек_на_производствеLabel.Location = new System.Drawing.Point(836, 454);
            количество_человек_на_производствеLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            количество_человек_на_производствеLabel.Name = "количество_человек_на_производствеLabel";
            количество_человек_на_производствеLabel.Size = new System.Drawing.Size(262, 16);
            количество_человек_на_производствеLabel.TabIndex = 35;
            количество_человек_на_производствеLabel.Text = "Количество человек на производстве:";
            // 
            // iD_ИсторииLabel
            // 
            iD_ИсторииLabel.AutoSize = true;
            iD_ИсторииLabel.Location = new System.Drawing.Point(191, 48);
            iD_ИсторииLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            iD_ИсторииLabel.Name = "iD_ИсторииLabel";
            iD_ИсторииLabel.Size = new System.Drawing.Size(82, 16);
            iD_ИсторииLabel.TabIndex = 1;
            iD_ИсторииLabel.Text = "ID Истории:";
            // 
            // iD_ПродукцииLabel1
            // 
            iD_ПродукцииLabel1.AutoSize = true;
            iD_ПродукцииLabel1.Location = new System.Drawing.Point(175, 80);
            iD_ПродукцииLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            iD_ПродукцииLabel1.Name = "iD_ПродукцииLabel1";
            iD_ПродукцииLabel1.Size = new System.Drawing.Size(99, 16);
            iD_ПродукцииLabel1.TabIndex = 3;
            iD_ПродукцииLabel1.Text = "ID Продукции:";
            // 
            // предыдущая_ценаLabel
            // 
            предыдущая_ценаLabel.AutoSize = true;
            предыдущая_ценаLabel.Location = new System.Drawing.Point(143, 112);
            предыдущая_ценаLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            предыдущая_ценаLabel.Name = "предыдущая_ценаLabel";
            предыдущая_ценаLabel.Size = new System.Drawing.Size(128, 16);
            предыдущая_ценаLabel.TabIndex = 5;
            предыдущая_ценаLabel.Text = "Предыдущая цена:";
            // 
            // текущая_ценаLabel
            // 
            текущая_ценаLabel.AutoSize = true;
            текущая_ценаLabel.Location = new System.Drawing.Point(171, 144);
            текущая_ценаLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            текущая_ценаLabel.Name = "текущая_ценаLabel";
            текущая_ценаLabel.Size = new System.Drawing.Size(101, 16);
            текущая_ценаLabel.TabIndex = 7;
            текущая_ценаLabel.Text = "Текущая цена:";
            // 
            // дата_измененияLabel
            // 
            дата_измененияLabel.AutoSize = true;
            дата_измененияLabel.Location = new System.Drawing.Point(20, 177);
            дата_измененияLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            дата_измененияLabel.Name = "дата_измененияLabel";
            дата_измененияLabel.Size = new System.Drawing.Size(117, 16);
            дата_измененияLabel.TabIndex = 9;
            дата_измененияLabel.Text = "Дата изменения:";
            // 
            // iD_МенеджераLabel
            // 
            iD_МенеджераLabel.AutoSize = true;
            iD_МенеджераLabel.Location = new System.Drawing.Point(121, 23);
            iD_МенеджераLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            iD_МенеджераLabel.Name = "iD_МенеджераLabel";
            iD_МенеджераLabel.Size = new System.Drawing.Size(102, 16);
            iD_МенеджераLabel.TabIndex = 1;
            iD_МенеджераLabel.Text = "ID Менеджера:";
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(183, 55);
            фИОLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(41, 16);
            фИОLabel.TabIndex = 3;
            фИОLabel.Text = "ФИО:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(159, 87);
            телефонLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(70, 16);
            телефонLabel.TabIndex = 5;
            телефонLabel.Text = "Телефон:";
            // 
            // почтаLabel
            // 
            почтаLabel.AutoSize = true;
            почтаLabel.Location = new System.Drawing.Point(179, 119);
            почтаLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            почтаLabel.Name = "почтаLabel";
            почтаLabel.Size = new System.Drawing.Size(51, 16);
            почтаLabel.TabIndex = 7;
            почтаLabel.Text = "Почта:";
            // 
            // iD_СотрудникаLabel
            // 
            iD_СотрудникаLabel.AutoSize = true;
            iD_СотрудникаLabel.Location = new System.Drawing.Point(121, 151);
            iD_СотрудникаLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            iD_СотрудникаLabel.Name = "iD_СотрудникаLabel";
            iD_СотрудникаLabel.Size = new System.Drawing.Size(105, 16);
            iD_СотрудникаLabel.TabIndex = 9;
            iD_СотрудникаLabel.Text = "ID Сотрудника:";
            // 
            // bikinaDataSet
            // 
            this.bikinaDataSet.DataSetName = "BikinaDataSet";
            this.bikinaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // иСТОРИЯ_ЦЕНBindingSource
            // 
            this.иСТОРИЯ_ЦЕНBindingSource.DataMember = "ИСТОРИЯ_ЦЕН";
            this.иСТОРИЯ_ЦЕНBindingSource.DataSource = this.bikinaDataSet;
            // 
            // иСТОРИЯ_ЦЕНTableAdapter
            // 
            this.иСТОРИЯ_ЦЕНTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Bikina.BikinaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДОСТУПTableAdapter = null;
            this.tableAdapterManager.ЗАЯВКИTableAdapter = null;
            this.tableAdapterManager.ИСТОРИЯ_ИЗМЕНЕНИЯ_РЕЙТИНГАTableAdapter = null;
            this.tableAdapterManager.ИСТОРИЯ_ЦЕНTableAdapter = this.иСТОРИЯ_ЦЕНTableAdapter;
            this.tableAdapterManager.КАДРЫTableAdapter = null;
            this.tableAdapterManager.МАТЕРИАЛЫ_ПРОДУКЦИЯTableAdapter = null;
            this.tableAdapterManager.МАТЕРИАЛЫTableAdapter = null;
            this.tableAdapterManager.МЕНЕДЖЕРЫTableAdapter = this.мЕНЕДЖЕРЫTableAdapter;
            this.tableAdapterManager.ПАРТНЕРЫTableAdapter = null;
            this.tableAdapterManager.ПОСТАВКАTableAdapter = null;
            this.tableAdapterManager.ПОСТАВЩИКИTableAdapter = null;
            this.tableAdapterManager.ПРОДУКЦИЯTableAdapter = this.пРОДУКЦИЯTableAdapter;
            this.tableAdapterManager.РЕАЛИЗАЦИЯTableAdapter = null;
            this.tableAdapterManager.СОТРУДНИКИTableAdapter = null;
            // 
            // мЕНЕДЖЕРЫTableAdapter
            // 
            this.мЕНЕДЖЕРЫTableAdapter.ClearBeforeFill = true;
            // 
            // пРОДУКЦИЯTableAdapter
            // 
            this.пРОДУКЦИЯTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1281, 558);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(207)))), ((int)(((byte)(206)))));
            this.tabPage1.Controls.Add(this.дОСТУПBindingNavigator);
            this.tabPage1.Controls.Add(количество_человек_на_производствеLabel);
            this.tabPage1.Controls.Add(this.количество_человек_на_производствеTextBox);
            this.tabPage1.Controls.Add(номер_цехаLabel);
            this.tabPage1.Controls.Add(this.номер_цехаTextBox);
            this.tabPage1.Controls.Add(себестоимостьLabel);
            this.tabPage1.Controls.Add(this.себестоимостьTextBox);
            this.tabPage1.Controls.Add(время_изготовленияLabel);
            this.tabPage1.Controls.Add(this.время_изготовленияTextBox);
            this.tabPage1.Controls.Add(номер_стандартаLabel);
            this.tabPage1.Controls.Add(this.номер_стандартаTextBox);
            this.tabPage1.Controls.Add(сертификат_качестваLabel);
            this.tabPage1.Controls.Add(this.сертификат_качестваTextBox);
            this.tabPage1.Controls.Add(вес_с_упаковкойLabel);
            this.tabPage1.Controls.Add(this.вес_с_упаковкойTextBox);
            this.tabPage1.Controls.Add(вес_без_упаковкиLabel);
            this.tabPage1.Controls.Add(this.вес_без_упаковкиTextBox);
            this.tabPage1.Controls.Add(высота_упаковкиLabel);
            this.tabPage1.Controls.Add(this.высота_упаковкиTextBox);
            this.tabPage1.Controls.Add(ширина_упаковкиLabel);
            this.tabPage1.Controls.Add(this.ширина_упаковкиTextBox);
            this.tabPage1.Controls.Add(длина_упаковкиLabel);
            this.tabPage1.Controls.Add(this.длина_упаковкиTextBox);
            this.tabPage1.Controls.Add(минимальная_стоимость_для_партнераLabel);
            this.tabPage1.Controls.Add(this.минимальная_стоимость_для_партнераTextBox);
            this.tabPage1.Controls.Add(изображениеLabel);
            this.tabPage1.Controls.Add(this.изображениеTextBox);
            this.tabPage1.Controls.Add(описаниеLabel);
            this.tabPage1.Controls.Add(this.описаниеTextBox);
            this.tabPage1.Controls.Add(наименованиеLabel);
            this.tabPage1.Controls.Add(this.наименованиеTextBox);
            this.tabPage1.Controls.Add(iD_Типа_ПродукцииLabel);
            this.tabPage1.Controls.Add(this.iD_Типа_ПродукцииTextBox);
            this.tabPage1.Controls.Add(артикулLabel);
            this.tabPage1.Controls.Add(this.артикулTextBox);
            this.tabPage1.Controls.Add(iD_ПродукцииLabel);
            this.tabPage1.Controls.Add(this.iD_ПродукцииTextBox);
            this.tabPage1.Controls.Add(this.пРОДУКЦИЯDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1273, 529);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Продукция";
            // 
            // дОСТУПBindingNavigator
            // 
            this.дОСТУПBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.дОСТУПBindingNavigator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.дОСТУПBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.дОСТУПBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.дОСТУПBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.дОСТУПBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.дОСТУПBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.дОСТУПBindingNavigatorSaveItem});
            this.дОСТУПBindingNavigator.Location = new System.Drawing.Point(4, 495);
            this.дОСТУПBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.дОСТУПBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.дОСТУПBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.дОСТУПBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.дОСТУПBindingNavigator.Name = "дОСТУПBindingNavigator";
            this.дОСТУПBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.дОСТУПBindingNavigator.Size = new System.Drawing.Size(356, 31);
            this.дОСТУПBindingNavigator.TabIndex = 37;
            this.дОСТУПBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // дОСТУПBindingNavigatorSaveItem
            // 
            this.дОСТУПBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.дОСТУПBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("дОСТУПBindingNavigatorSaveItem.Image")));
            this.дОСТУПBindingNavigatorSaveItem.Name = "дОСТУПBindingNavigatorSaveItem";
            this.дОСТУПBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.дОСТУПBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // количество_человек_на_производствеTextBox
            // 
            this.количество_человек_на_производствеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пРОДУКЦИЯBindingSource, "Количество_человек_на_производстве", true));
            this.количество_человек_на_производствеTextBox.Location = new System.Drawing.Point(1113, 450);
            this.количество_человек_на_производствеTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.количество_человек_на_производствеTextBox.Name = "количество_человек_на_производствеTextBox";
            this.количество_человек_на_производствеTextBox.Size = new System.Drawing.Size(132, 22);
            this.количество_человек_на_производствеTextBox.TabIndex = 36;
            // 
            // пРОДУКЦИЯBindingSource
            // 
            this.пРОДУКЦИЯBindingSource.DataMember = "ПРОДУКЦИЯ";
            this.пРОДУКЦИЯBindingSource.DataSource = this.bikinaDataSet;
            // 
            // номер_цехаTextBox
            // 
            this.номер_цехаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пРОДУКЦИЯBindingSource, "Номер_цеха", true));
            this.номер_цехаTextBox.Location = new System.Drawing.Point(1113, 418);
            this.номер_цехаTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.номер_цехаTextBox.Name = "номер_цехаTextBox";
            this.номер_цехаTextBox.Size = new System.Drawing.Size(132, 22);
            this.номер_цехаTextBox.TabIndex = 34;
            // 
            // себестоимостьTextBox
            // 
            this.себестоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пРОДУКЦИЯBindingSource, "Себестоимость", true));
            this.себестоимостьTextBox.Location = new System.Drawing.Point(1113, 386);
            this.себестоимостьTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.себестоимостьTextBox.Name = "себестоимостьTextBox";
            this.себестоимостьTextBox.Size = new System.Drawing.Size(132, 22);
            this.себестоимостьTextBox.TabIndex = 32;
            // 
            // время_изготовленияTextBox
            // 
            this.время_изготовленияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пРОДУКЦИЯBindingSource, "Время_изготовления", true));
            this.время_изготовленияTextBox.Location = new System.Drawing.Point(1113, 354);
            this.время_изготовленияTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.время_изготовленияTextBox.Name = "время_изготовленияTextBox";
            this.время_изготовленияTextBox.Size = new System.Drawing.Size(132, 22);
            this.время_изготовленияTextBox.TabIndex = 30;
            // 
            // номер_стандартаTextBox
            // 
            this.номер_стандартаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пРОДУКЦИЯBindingSource, "Номер_стандарта", true));
            this.номер_стандартаTextBox.Location = new System.Drawing.Point(1113, 322);
            this.номер_стандартаTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.номер_стандартаTextBox.Name = "номер_стандартаTextBox";
            this.номер_стандартаTextBox.Size = new System.Drawing.Size(132, 22);
            this.номер_стандартаTextBox.TabIndex = 28;
            // 
            // сертификат_качестваTextBox
            // 
            this.сертификат_качестваTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пРОДУКЦИЯBindingSource, "Сертификат_качества", true));
            this.сертификат_качестваTextBox.Location = new System.Drawing.Point(1113, 290);
            this.сертификат_качестваTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.сертификат_качестваTextBox.Name = "сертификат_качестваTextBox";
            this.сертификат_качестваTextBox.Size = new System.Drawing.Size(132, 22);
            this.сертификат_качестваTextBox.TabIndex = 26;
            // 
            // вес_с_упаковкойTextBox
            // 
            this.вес_с_упаковкойTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пРОДУКЦИЯBindingSource, "Вес_с_упаковкой", true));
            this.вес_с_упаковкойTextBox.Location = new System.Drawing.Point(683, 446);
            this.вес_с_упаковкойTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.вес_с_упаковкойTextBox.Name = "вес_с_упаковкойTextBox";
            this.вес_с_упаковкойTextBox.Size = new System.Drawing.Size(132, 22);
            this.вес_с_упаковкойTextBox.TabIndex = 24;
            // 
            // вес_без_упаковкиTextBox
            // 
            this.вес_без_упаковкиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пРОДУКЦИЯBindingSource, "Вес_без_упаковки", true));
            this.вес_без_упаковкиTextBox.Location = new System.Drawing.Point(683, 414);
            this.вес_без_упаковкиTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.вес_без_упаковкиTextBox.Name = "вес_без_упаковкиTextBox";
            this.вес_без_упаковкиTextBox.Size = new System.Drawing.Size(132, 22);
            this.вес_без_упаковкиTextBox.TabIndex = 22;
            // 
            // высота_упаковкиTextBox
            // 
            this.высота_упаковкиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пРОДУКЦИЯBindingSource, "Высота_упаковки", true));
            this.высота_упаковкиTextBox.Location = new System.Drawing.Point(683, 382);
            this.высота_упаковкиTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.высота_упаковкиTextBox.Name = "высота_упаковкиTextBox";
            this.высота_упаковкиTextBox.Size = new System.Drawing.Size(132, 22);
            this.высота_упаковкиTextBox.TabIndex = 20;
            // 
            // ширина_упаковкиTextBox
            // 
            this.ширина_упаковкиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пРОДУКЦИЯBindingSource, "Ширина_упаковки", true));
            this.ширина_упаковкиTextBox.Location = new System.Drawing.Point(683, 350);
            this.ширина_упаковкиTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ширина_упаковкиTextBox.Name = "ширина_упаковкиTextBox";
            this.ширина_упаковкиTextBox.Size = new System.Drawing.Size(132, 22);
            this.ширина_упаковкиTextBox.TabIndex = 18;
            // 
            // длина_упаковкиTextBox
            // 
            this.длина_упаковкиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пРОДУКЦИЯBindingSource, "Длина_упаковки", true));
            this.длина_упаковкиTextBox.Location = new System.Drawing.Point(683, 318);
            this.длина_упаковкиTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.длина_упаковкиTextBox.Name = "длина_упаковкиTextBox";
            this.длина_упаковкиTextBox.Size = new System.Drawing.Size(132, 22);
            this.длина_упаковкиTextBox.TabIndex = 16;
            // 
            // минимальная_стоимость_для_партнераTextBox
            // 
            this.минимальная_стоимость_для_партнераTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пРОДУКЦИЯBindingSource, "Минимальная_стоимость_для_партнера", true));
            this.минимальная_стоимость_для_партнераTextBox.Location = new System.Drawing.Point(683, 286);
            this.минимальная_стоимость_для_партнераTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.минимальная_стоимость_для_партнераTextBox.Name = "минимальная_стоимость_для_партнераTextBox";
            this.минимальная_стоимость_для_партнераTextBox.Size = new System.Drawing.Size(132, 22);
            this.минимальная_стоимость_для_партнераTextBox.TabIndex = 14;
            // 
            // изображениеTextBox
            // 
            this.изображениеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пРОДУКЦИЯBindingSource, "Изображение", true));
            this.изображениеTextBox.Location = new System.Drawing.Point(241, 446);
            this.изображениеTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.изображениеTextBox.Name = "изображениеTextBox";
            this.изображениеTextBox.Size = new System.Drawing.Size(132, 22);
            this.изображениеTextBox.TabIndex = 12;
            // 
            // описаниеTextBox
            // 
            this.описаниеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пРОДУКЦИЯBindingSource, "Описание", true));
            this.описаниеTextBox.Location = new System.Drawing.Point(241, 414);
            this.описаниеTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.описаниеTextBox.Name = "описаниеTextBox";
            this.описаниеTextBox.Size = new System.Drawing.Size(132, 22);
            this.описаниеTextBox.TabIndex = 10;
            // 
            // наименованиеTextBox
            // 
            this.наименованиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пРОДУКЦИЯBindingSource, "Наименование", true));
            this.наименованиеTextBox.Location = new System.Drawing.Point(241, 382);
            this.наименованиеTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.наименованиеTextBox.Name = "наименованиеTextBox";
            this.наименованиеTextBox.Size = new System.Drawing.Size(132, 22);
            this.наименованиеTextBox.TabIndex = 8;
            // 
            // iD_Типа_ПродукцииTextBox
            // 
            this.iD_Типа_ПродукцииTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пРОДУКЦИЯBindingSource, "ID_Типа_Продукции", true));
            this.iD_Типа_ПродукцииTextBox.Location = new System.Drawing.Point(241, 350);
            this.iD_Типа_ПродукцииTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.iD_Типа_ПродукцииTextBox.Name = "iD_Типа_ПродукцииTextBox";
            this.iD_Типа_ПродукцииTextBox.Size = new System.Drawing.Size(132, 22);
            this.iD_Типа_ПродукцииTextBox.TabIndex = 6;
            // 
            // артикулTextBox
            // 
            this.артикулTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пРОДУКЦИЯBindingSource, "Артикул", true));
            this.артикулTextBox.Location = new System.Drawing.Point(241, 318);
            this.артикулTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.артикулTextBox.Name = "артикулTextBox";
            this.артикулTextBox.Size = new System.Drawing.Size(132, 22);
            this.артикулTextBox.TabIndex = 4;
            // 
            // iD_ПродукцииTextBox
            // 
            this.iD_ПродукцииTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пРОДУКЦИЯBindingSource, "ID_Продукции", true));
            this.iD_ПродукцииTextBox.Location = new System.Drawing.Point(241, 286);
            this.iD_ПродукцииTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.iD_ПродукцииTextBox.Name = "iD_ПродукцииTextBox";
            this.iD_ПродукцииTextBox.Size = new System.Drawing.Size(132, 22);
            this.iD_ПродукцииTextBox.TabIndex = 2;
            // 
            // пРОДУКЦИЯDataGridView
            // 
            this.пРОДУКЦИЯDataGridView.AutoGenerateColumns = false;
            this.пРОДУКЦИЯDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(111)))), ((int)(((byte)(148)))));
            this.пРОДУКЦИЯDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.пРОДУКЦИЯDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.пРОДУКЦИЯDataGridView.DataSource = this.пРОДУКЦИЯBindingSource;
            this.пРОДУКЦИЯDataGridView.Location = new System.Drawing.Point(0, 0);
            this.пРОДУКЦИЯDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.пРОДУКЦИЯDataGridView.Name = "пРОДУКЦИЯDataGridView";
            this.пРОДУКЦИЯDataGridView.ReadOnly = true;
            this.пРОДУКЦИЯDataGridView.RowHeadersWidth = 51;
            this.пРОДУКЦИЯDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.пРОДУКЦИЯDataGridView.Size = new System.Drawing.Size(1263, 271);
            this.пРОДУКЦИЯDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Продукции";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Продукции";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Артикул";
            this.dataGridViewTextBoxColumn2.HeaderText = "Артикул";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_Типа_Продукции";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID_Типа_Продукции";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Наименование";
            this.dataGridViewTextBoxColumn4.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Описание";
            this.dataGridViewTextBoxColumn5.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Изображение";
            this.dataGridViewTextBoxColumn6.HeaderText = "Изображение";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Минимальная_стоимость_для_партнера";
            this.dataGridViewTextBoxColumn7.HeaderText = "Минимальная_стоимость_для_партнера";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Длина_упаковки";
            this.dataGridViewTextBoxColumn8.HeaderText = "Длина_упаковки";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Ширина_упаковки";
            this.dataGridViewTextBoxColumn9.HeaderText = "Ширина_упаковки";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Высота_упаковки";
            this.dataGridViewTextBoxColumn10.HeaderText = "Высота_упаковки";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Вес_без_упаковки";
            this.dataGridViewTextBoxColumn11.HeaderText = "Вес_без_упаковки";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Вес_с_упаковкой";
            this.dataGridViewTextBoxColumn12.HeaderText = "Вес_с_упаковкой";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Сертификат_качества";
            this.dataGridViewTextBoxColumn13.HeaderText = "Сертификат_качества";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Номер_стандарта";
            this.dataGridViewTextBoxColumn14.HeaderText = "Номер_стандарта";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Время_изготовления";
            this.dataGridViewTextBoxColumn15.HeaderText = "Время_изготовления";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 125;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Себестоимость";
            this.dataGridViewTextBoxColumn16.HeaderText = "Себестоимость";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 125;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Номер_цеха";
            this.dataGridViewTextBoxColumn17.HeaderText = "Номер_цеха";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 125;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Количество_человек_на_производстве";
            this.dataGridViewTextBoxColumn18.HeaderText = "Количество_человек_на_производстве";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 125;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bindingNavigator1);
            this.tabPage2.Controls.Add(дата_измененияLabel);
            this.tabPage2.Controls.Add(this.дата_измененияDateTimePicker);
            this.tabPage2.Controls.Add(текущая_ценаLabel);
            this.tabPage2.Controls.Add(this.текущая_ценаTextBox);
            this.tabPage2.Controls.Add(предыдущая_ценаLabel);
            this.tabPage2.Controls.Add(this.предыдущая_ценаTextBox);
            this.tabPage2.Controls.Add(iD_ПродукцииLabel1);
            this.tabPage2.Controls.Add(this.iD_ПродукцииTextBox1);
            this.tabPage2.Controls.Add(iD_ИсторииLabel);
            this.tabPage2.Controls.Add(this.iD_ИсторииTextBox);
            this.tabPage2.Controls.Add(this.иСТОРИЯ_ЦЕНDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1273, 529);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "История цен";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.toolStripButton1;
            this.bindingNavigator1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bindingNavigator1.CountItem = this.toolStripLabel1;
            this.bindingNavigator1.DeleteItem = this.toolStripButton2;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton7});
            this.bindingNavigator1.Location = new System.Drawing.Point(49, 244);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton3;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton6;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton5;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton4;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator1.Size = new System.Drawing.Size(356, 27);
            this.bindingNavigator1.TabIndex = 8;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "Добавить";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(55, 24);
            this.toolStripLabel1.Text = "для {0}";
            this.toolStripLabel1.ToolTipText = "Общее число элементов";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "Удалить";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton3.Text = "Переместить в начало";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton4.Text = "Переместить назад";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Положение";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(65, 27);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Текущее положение";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton5.Text = "Переместить вперед";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton6.Text = "Переместить в конец";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton7.Text = "Сохранить данные";
            // 
            // дата_измененияDateTimePicker
            // 
            this.дата_измененияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.иСТОРИЯ_ЦЕНBindingSource1, "Дата_изменения", true));
            this.дата_измененияDateTimePicker.Location = new System.Drawing.Point(155, 172);
            this.дата_измененияDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.дата_измененияDateTimePicker.Name = "дата_измененияDateTimePicker";
            this.дата_измененияDateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.дата_измененияDateTimePicker.TabIndex = 10;
            // 
            // иСТОРИЯ_ЦЕНBindingSource1
            // 
            this.иСТОРИЯ_ЦЕНBindingSource1.DataMember = "FK__ИСТОРИЯ_Ц__ID_Пр__5629CD9C";
            this.иСТОРИЯ_ЦЕНBindingSource1.DataSource = this.пРОДУКЦИЯBindingSource;
            // 
            // текущая_ценаTextBox
            // 
            this.текущая_ценаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.иСТОРИЯ_ЦЕНBindingSource1, "Текущая_цена", true));
            this.текущая_ценаTextBox.Location = new System.Drawing.Point(288, 140);
            this.текущая_ценаTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.текущая_ценаTextBox.Name = "текущая_ценаTextBox";
            this.текущая_ценаTextBox.Size = new System.Drawing.Size(132, 22);
            this.текущая_ценаTextBox.TabIndex = 8;
            // 
            // предыдущая_ценаTextBox
            // 
            this.предыдущая_ценаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.иСТОРИЯ_ЦЕНBindingSource1, "Предыдущая_цена", true));
            this.предыдущая_ценаTextBox.Location = new System.Drawing.Point(288, 108);
            this.предыдущая_ценаTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.предыдущая_ценаTextBox.Name = "предыдущая_ценаTextBox";
            this.предыдущая_ценаTextBox.Size = new System.Drawing.Size(132, 22);
            this.предыдущая_ценаTextBox.TabIndex = 6;
            // 
            // iD_ПродукцииTextBox1
            // 
            this.iD_ПродукцииTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.иСТОРИЯ_ЦЕНBindingSource1, "ID_Продукции", true));
            this.iD_ПродукцииTextBox1.Location = new System.Drawing.Point(288, 76);
            this.iD_ПродукцииTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.iD_ПродукцииTextBox1.Name = "iD_ПродукцииTextBox1";
            this.iD_ПродукцииTextBox1.Size = new System.Drawing.Size(132, 22);
            this.iD_ПродукцииTextBox1.TabIndex = 4;
            // 
            // iD_ИсторииTextBox
            // 
            this.iD_ИсторииTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.иСТОРИЯ_ЦЕНBindingSource1, "ID_Истории", true));
            this.iD_ИсторииTextBox.Location = new System.Drawing.Point(288, 44);
            this.iD_ИсторииTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.iD_ИсторииTextBox.Name = "iD_ИсторииTextBox";
            this.iD_ИсторииTextBox.Size = new System.Drawing.Size(132, 22);
            this.iD_ИсторииTextBox.TabIndex = 2;
            // 
            // иСТОРИЯ_ЦЕНDataGridView
            // 
            this.иСТОРИЯ_ЦЕНDataGridView.AutoGenerateColumns = false;
            this.иСТОРИЯ_ЦЕНDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.иСТОРИЯ_ЦЕНDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23});
            this.иСТОРИЯ_ЦЕНDataGridView.DataSource = this.иСТОРИЯ_ЦЕНBindingSource1;
            this.иСТОРИЯ_ЦЕНDataGridView.Location = new System.Drawing.Point(504, 4);
            this.иСТОРИЯ_ЦЕНDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.иСТОРИЯ_ЦЕНDataGridView.Name = "иСТОРИЯ_ЦЕНDataGridView";
            this.иСТОРИЯ_ЦЕНDataGridView.ReadOnly = true;
            this.иСТОРИЯ_ЦЕНDataGridView.RowHeadersWidth = 51;
            this.иСТОРИЯ_ЦЕНDataGridView.Size = new System.Drawing.Size(725, 271);
            this.иСТОРИЯ_ЦЕНDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "ID_Истории";
            this.dataGridViewTextBoxColumn19.HeaderText = "ID_Истории";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 125;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "ID_Продукции";
            this.dataGridViewTextBoxColumn20.HeaderText = "ID_Продукции";
            this.dataGridViewTextBoxColumn20.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Width = 125;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Предыдущая_цена";
            this.dataGridViewTextBoxColumn21.HeaderText = "Предыдущая_цена";
            this.dataGridViewTextBoxColumn21.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Width = 125;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Текущая_цена";
            this.dataGridViewTextBoxColumn22.HeaderText = "Текущая_цена";
            this.dataGridViewTextBoxColumn22.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            this.dataGridViewTextBoxColumn22.Width = 125;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Дата_изменения";
            this.dataGridViewTextBoxColumn23.HeaderText = "Дата_изменения";
            this.dataGridViewTextBoxColumn23.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            this.dataGridViewTextBoxColumn23.Width = 125;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.bindingNavigator2);
            this.tabPage3.Controls.Add(iD_СотрудникаLabel);
            this.tabPage3.Controls.Add(this.iD_СотрудникаTextBox);
            this.tabPage3.Controls.Add(почтаLabel);
            this.tabPage3.Controls.Add(this.почтаTextBox);
            this.tabPage3.Controls.Add(телефонLabel);
            this.tabPage3.Controls.Add(this.телефонTextBox);
            this.tabPage3.Controls.Add(фИОLabel);
            this.tabPage3.Controls.Add(this.фИОTextBox);
            this.tabPage3.Controls.Add(iD_МенеджераLabel);
            this.tabPage3.Controls.Add(this.iD_МенеджераTextBox);
            this.tabPage3.Controls.Add(this.мЕНЕДЖЕРЫDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1273, 529);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Менеджеры";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = this.toolStripButton8;
            this.bindingNavigator2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bindingNavigator2.CountItem = this.toolStripLabel2;
            this.bindingNavigator2.DeleteItem = this.toolStripButton9;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton10,
            this.toolStripButton11,
            this.toolStripSeparator4,
            this.toolStripTextBox2,
            this.toolStripLabel2,
            this.toolStripSeparator5,
            this.toolStripButton12,
            this.toolStripButton13,
            this.toolStripSeparator6,
            this.toolStripButton8,
            this.toolStripButton9,
            this.toolStripButton14});
            this.bindingNavigator2.Location = new System.Drawing.Point(65, 244);
            this.bindingNavigator2.MoveFirstItem = this.toolStripButton10;
            this.bindingNavigator2.MoveLastItem = this.toolStripButton13;
            this.bindingNavigator2.MoveNextItem = this.toolStripButton12;
            this.bindingNavigator2.MovePreviousItem = this.toolStripButton11;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.toolStripTextBox2;
            this.bindingNavigator2.Size = new System.Drawing.Size(356, 27);
            this.bindingNavigator2.TabIndex = 11;
            this.bindingNavigator2.Text = "bindingNavigator1";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.RightToLeftAutoMirrorImage = true;
            this.toolStripButton8.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton8.Text = "Добавить";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(55, 24);
            this.toolStripLabel2.Text = "для {0}";
            this.toolStripLabel2.ToolTipText = "Общее число элементов";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.RightToLeftAutoMirrorImage = true;
            this.toolStripButton9.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton9.Text = "Удалить";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.RightToLeftAutoMirrorImage = true;
            this.toolStripButton10.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton10.Text = "Переместить в начало";
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.RightToLeftAutoMirrorImage = true;
            this.toolStripButton11.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton11.Text = "Переместить назад";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AccessibleName = "Положение";
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(65, 27);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "Текущее положение";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.RightToLeftAutoMirrorImage = true;
            this.toolStripButton12.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton12.Text = "Переместить вперед";
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.RightToLeftAutoMirrorImage = true;
            this.toolStripButton13.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton13.Text = "Переместить в конец";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton14.Text = "Сохранить данные";
            // 
            // iD_СотрудникаTextBox
            // 
            this.iD_СотрудникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.мЕНЕДЖЕРЫBindingSource, "ID_Сотрудника", true));
            this.iD_СотрудникаTextBox.Location = new System.Drawing.Point(240, 148);
            this.iD_СотрудникаTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.iD_СотрудникаTextBox.Name = "iD_СотрудникаTextBox";
            this.iD_СотрудникаTextBox.Size = new System.Drawing.Size(132, 22);
            this.iD_СотрудникаTextBox.TabIndex = 10;
            // 
            // мЕНЕДЖЕРЫBindingSource
            // 
            this.мЕНЕДЖЕРЫBindingSource.DataMember = "МЕНЕДЖЕРЫ";
            this.мЕНЕДЖЕРЫBindingSource.DataSource = this.bikinaDataSet;
            // 
            // почтаTextBox
            // 
            this.почтаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.мЕНЕДЖЕРЫBindingSource, "Почта", true));
            this.почтаTextBox.Location = new System.Drawing.Point(240, 116);
            this.почтаTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.почтаTextBox.Name = "почтаTextBox";
            this.почтаTextBox.Size = new System.Drawing.Size(132, 22);
            this.почтаTextBox.TabIndex = 8;
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.мЕНЕДЖЕРЫBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(240, 84);
            this.телефонTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(132, 22);
            this.телефонTextBox.TabIndex = 6;
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.мЕНЕДЖЕРЫBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(240, 52);
            this.фИОTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(132, 22);
            this.фИОTextBox.TabIndex = 4;
            // 
            // iD_МенеджераTextBox
            // 
            this.iD_МенеджераTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.мЕНЕДЖЕРЫBindingSource, "ID_Менеджера", true));
            this.iD_МенеджераTextBox.Location = new System.Drawing.Point(240, 20);
            this.iD_МенеджераTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.iD_МенеджераTextBox.Name = "iD_МенеджераTextBox";
            this.iD_МенеджераTextBox.Size = new System.Drawing.Size(132, 22);
            this.iD_МенеджераTextBox.TabIndex = 2;
            // 
            // мЕНЕДЖЕРЫDataGridView
            // 
            this.мЕНЕДЖЕРЫDataGridView.AutoGenerateColumns = false;
            this.мЕНЕДЖЕРЫDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.мЕНЕДЖЕРЫDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28});
            this.мЕНЕДЖЕРЫDataGridView.DataSource = this.мЕНЕДЖЕРЫBindingSource;
            this.мЕНЕДЖЕРЫDataGridView.Location = new System.Drawing.Point(517, 4);
            this.мЕНЕДЖЕРЫDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.мЕНЕДЖЕРЫDataGridView.Name = "мЕНЕДЖЕРЫDataGridView";
            this.мЕНЕДЖЕРЫDataGridView.RowHeadersWidth = 51;
            this.мЕНЕДЖЕРЫDataGridView.Size = new System.Drawing.Size(731, 271);
            this.мЕНЕДЖЕРЫDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "ID_Менеджера";
            this.dataGridViewTextBoxColumn24.HeaderText = "ID_Менеджера";
            this.dataGridViewTextBoxColumn24.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            this.dataGridViewTextBoxColumn24.Width = 125;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn25.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn25.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.Width = 125;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn26.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn26.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.Width = 125;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "Почта";
            this.dataGridViewTextBoxColumn27.HeaderText = "Почта";
            this.dataGridViewTextBoxColumn27.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.Width = 125;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "ID_Сотрудника";
            this.dataGridViewTextBoxColumn28.HeaderText = "ID_Сотрудника";
            this.dataGridViewTextBoxColumn28.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.Width = 125;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1292, 575);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "ПАРТНЕРЫ";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bikinaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.иСТОРИЯ_ЦЕНBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.дОСТУПBindingNavigator)).EndInit();
            this.дОСТУПBindingNavigator.ResumeLayout(false);
            this.дОСТУПBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.пРОДУКЦИЯBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пРОДУКЦИЯDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.иСТОРИЯ_ЦЕНBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.иСТОРИЯ_ЦЕНDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.мЕНЕДЖЕРЫBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мЕНЕДЖЕРЫDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BikinaDataSet bikinaDataSet;
        private System.Windows.Forms.BindingSource иСТОРИЯ_ЦЕНBindingSource;
        private BikinaDataSetTableAdapters.ИСТОРИЯ_ЦЕНTableAdapter иСТОРИЯ_ЦЕНTableAdapter;
        private BikinaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private BikinaDataSetTableAdapters.ПРОДУКЦИЯTableAdapter пРОДУКЦИЯTableAdapter;
        private System.Windows.Forms.BindingSource пРОДУКЦИЯBindingSource;
        private System.Windows.Forms.TextBox количество_человек_на_производствеTextBox;
        private System.Windows.Forms.TextBox номер_цехаTextBox;
        private System.Windows.Forms.TextBox себестоимостьTextBox;
        private System.Windows.Forms.TextBox время_изготовленияTextBox;
        private System.Windows.Forms.TextBox номер_стандартаTextBox;
        private System.Windows.Forms.TextBox сертификат_качестваTextBox;
        private System.Windows.Forms.TextBox вес_с_упаковкойTextBox;
        private System.Windows.Forms.TextBox вес_без_упаковкиTextBox;
        private System.Windows.Forms.TextBox высота_упаковкиTextBox;
        private System.Windows.Forms.TextBox ширина_упаковкиTextBox;
        private System.Windows.Forms.TextBox длина_упаковкиTextBox;
        private System.Windows.Forms.TextBox минимальная_стоимость_для_партнераTextBox;
        private System.Windows.Forms.TextBox изображениеTextBox;
        private System.Windows.Forms.TextBox описаниеTextBox;
        private System.Windows.Forms.TextBox наименованиеTextBox;
        private System.Windows.Forms.TextBox iD_Типа_ПродукцииTextBox;
        private System.Windows.Forms.TextBox артикулTextBox;
        private System.Windows.Forms.TextBox iD_ПродукцииTextBox;
        private System.Windows.Forms.DataGridView пРОДУКЦИЯDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DateTimePicker дата_измененияDateTimePicker;
        private System.Windows.Forms.BindingSource иСТОРИЯ_ЦЕНBindingSource1;
        private System.Windows.Forms.TextBox текущая_ценаTextBox;
        private System.Windows.Forms.TextBox предыдущая_ценаTextBox;
        private System.Windows.Forms.TextBox iD_ПродукцииTextBox1;
        private System.Windows.Forms.TextBox iD_ИсторииTextBox;
        private System.Windows.Forms.DataGridView иСТОРИЯ_ЦЕНDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private BikinaDataSetTableAdapters.МЕНЕДЖЕРЫTableAdapter мЕНЕДЖЕРЫTableAdapter;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.BindingSource мЕНЕДЖЕРЫBindingSource;
        private System.Windows.Forms.DataGridView мЕНЕДЖЕРЫDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.TextBox iD_СотрудникаTextBox;
        private System.Windows.Forms.TextBox почтаTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.TextBox iD_МенеджераTextBox;
        private System.Windows.Forms.BindingNavigator дОСТУПBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton дОСТУПBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
    }
}