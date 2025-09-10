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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void мАТЕРИАЛЫBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.мАТЕРИАЛЫBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bikinaDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bikinaDataSet.МАТЕРИАЛЫ_ПРОДУКЦИЯ". При необходимости она может быть перемещена или удалена.
            this.мАТЕРИАЛЫ_ПРОДУКЦИЯTableAdapter.Fill(this.bikinaDataSet.МАТЕРИАЛЫ_ПРОДУКЦИЯ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bikinaDataSet.МАТЕРИАЛЫ". При необходимости она может быть перемещена или удалена.
            this.мАТЕРИАЛЫTableAdapter.Fill(this.bikinaDataSet.МАТЕРИАЛЫ);

        }
    }
}
