namespace Bikina
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.bikinaDataSet = new Bikina.BikinaDataSet();
            this.дОСТУПBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.дОСТУПTableAdapter = new Bikina.BikinaDataSetTableAdapters.ДОСТУПTableAdapter();
            this.tableAdapterManager = new Bikina.BikinaDataSetTableAdapters.TableAdapterManager();
            this.мЕНЕДЖЕРЫBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.мЕНЕДЖЕРЫTableAdapter = new Bikina.BikinaDataSetTableAdapters.МЕНЕДЖЕРЫTableAdapter();
            this.пОСТАВКАBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пОСТАВКАTableAdapter = new Bikina.BikinaDataSetTableAdapters.ПОСТАВКАTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bikinaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.дОСТУПBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мЕНЕДЖЕРЫBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пОСТАВКАBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(76, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "ВХОД";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtUsername.Location = new System.Drawing.Point(96, 90);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(132, 26);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword.Location = new System.Drawing.Point(96, 125);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(132, 26);
            this.txtPassword.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пароль";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(111)))), ((int)(((byte)(148)))));
            this.btnLogin.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogin.Location = new System.Drawing.Point(21, 169);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(208, 30);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Войти";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // bikinaDataSet
            // 
            this.bikinaDataSet.DataSetName = "BikinaDataSet";
            this.bikinaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // дОСТУПBindingSource
            // 
            this.дОСТУПBindingSource.DataMember = "ДОСТУП";
            this.дОСТУПBindingSource.DataSource = this.bikinaDataSet;
            // 
            // дОСТУПTableAdapter
            // 
            this.дОСТУПTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Bikina.BikinaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДОСТУПTableAdapter = this.дОСТУПTableAdapter;
            this.tableAdapterManager.ЗАЯВКИTableAdapter = null;
            this.tableAdapterManager.ИСТОРИЯ_ИЗМЕНЕНИЯ_РЕЙТИНГАTableAdapter = null;
            this.tableAdapterManager.ИСТОРИЯ_ЦЕНTableAdapter = null;
            this.tableAdapterManager.КАДРЫTableAdapter = null;
            this.tableAdapterManager.МАТЕРИАЛЫ_ПРОДУКЦИЯTableAdapter = null;
            this.tableAdapterManager.МАТЕРИАЛЫTableAdapter = null;
            this.tableAdapterManager.МЕНЕДЖЕРЫTableAdapter = null;
            this.tableAdapterManager.ПАРТНЕРЫTableAdapter = null;
            this.tableAdapterManager.ПОСТАВКАTableAdapter = null;
            this.tableAdapterManager.ПОСТАВЩИКИTableAdapter = null;
            this.tableAdapterManager.ПРОДУКЦИЯTableAdapter = null;
            this.tableAdapterManager.РЕАЛИЗАЦИЯTableAdapter = null;
            this.tableAdapterManager.СОТРУДНИКИTableAdapter = null;
            // 
            // мЕНЕДЖЕРЫBindingSource
            // 
            this.мЕНЕДЖЕРЫBindingSource.DataMember = "МЕНЕДЖЕРЫ";
            this.мЕНЕДЖЕРЫBindingSource.DataSource = this.bikinaDataSet;
            // 
            // мЕНЕДЖЕРЫTableAdapter
            // 
            this.мЕНЕДЖЕРЫTableAdapter.ClearBeforeFill = true;
            // 
            // пОСТАВКАBindingSource
            // 
            this.пОСТАВКАBindingSource.DataMember = "ПОСТАВКА";
            this.пОСТАВКАBindingSource.DataSource = this.bikinaDataSet;
            // 
            // пОСТАВКАTableAdapter
            // 
            this.пОСТАВКАTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(207)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(245, 229);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "ВХОД";
            this.Activated += new System.EventHandler(this.Form1_Load);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.bikinaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.дОСТУПBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мЕНЕДЖЕРЫBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пОСТАВКАBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogin;
        private BikinaDataSet bikinaDataSet;
        private System.Windows.Forms.BindingSource дОСТУПBindingSource;
        private BikinaDataSetTableAdapters.ДОСТУПTableAdapter дОСТУПTableAdapter;
        private BikinaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource мЕНЕДЖЕРЫBindingSource;
        private BikinaDataSetTableAdapters.МЕНЕДЖЕРЫTableAdapter мЕНЕДЖЕРЫTableAdapter;
        private System.Windows.Forms.BindingSource пОСТАВКАBindingSource;
        private BikinaDataSetTableAdapters.ПОСТАВКАTableAdapter пОСТАВКАTableAdapter;
    }
}

