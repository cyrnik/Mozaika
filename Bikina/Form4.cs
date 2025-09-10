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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void мАТЕРИАЛЫBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.мАТЕРИАЛЫBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bikinaDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bikinaDataSet.ПОСТАВКА". При необходимости она может быть перемещена или удалена.
            this.пОСТАВКАTableAdapter.Fill(this.bikinaDataSet.ПОСТАВКА);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bikinaDataSet.ПОСТАВЩИКИ". При необходимости она может быть перемещена или удалена.
            this.пОСТАВЩИКИTableAdapter.Fill(this.bikinaDataSet.ПОСТАВЩИКИ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bikinaDataSet.МАТЕРИАЛЫ". При необходимости она может быть перемещена или удалена.
            this.мАТЕРИАЛЫTableAdapter.Fill(this.bikinaDataSet.МАТЕРИАЛЫ);

        }

        private void наименование_компанииLabel_Click(object sender, EventArgs e)
        {

        }

        private void наименование_компанииTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
