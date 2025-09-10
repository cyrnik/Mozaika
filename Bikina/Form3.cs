using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bikina
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void иСТОРИЯ_ЦЕНBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.иСТОРИЯ_ЦЕНBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bikinaDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bikinaDataSet.МЕНЕДЖЕРЫ". При необходимости она может быть перемещена или удалена.
            this.мЕНЕДЖЕРЫTableAdapter.Fill(this.bikinaDataSet.МЕНЕДЖЕРЫ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bikinaDataSet.ПРОДУКЦИЯ". При необходимости она может быть перемещена или удалена.
            this.пРОДУКЦИЯTableAdapter.Fill(this.bikinaDataSet.ПРОДУКЦИЯ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bikinaDataSet.ПРОДУКЦИЯ". При необходимости она может быть перемещена или удалена.
            this.пРОДУКЦИЯTableAdapter.Fill(this.bikinaDataSet.ПРОДУКЦИЯ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bikinaDataSet.ИСТОРИЯ_ЦЕН". При необходимости она может быть перемещена или удалена.
            this.иСТОРИЯ_ЦЕНTableAdapter.Fill(this.bikinaDataSet.ИСТОРИЯ_ЦЕН);

        }
    }
}
