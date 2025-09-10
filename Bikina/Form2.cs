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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }


        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bikinaDataSet.РЕАЛИЗАЦИЯ". При необходимости она может быть перемещена или удалена.
            this.рЕАЛИЗАЦИЯTableAdapter.Fill(this.bikinaDataSet.РЕАЛИЗАЦИЯ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bikinaDataSet.ЗАЯВКИ". При необходимости она может быть перемещена или удалена.
            this.зАЯВКИTableAdapter.Fill(this.bikinaDataSet.ЗАЯВКИ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bikinaDataSet.ИСТОРИЯ_ИЗМЕНЕНИЯ_РЕЙТИНГА". При необходимости она может быть перемещена или удалена.
            this.иСТОРИЯ_ИЗМЕНЕНИЯ_РЕЙТИНГАTableAdapter.Fill(this.bikinaDataSet.ИСТОРИЯ_ИЗМЕНЕНИЯ_РЕЙТИНГА);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bikinaDataSet.ИСТОРИЯ_ЦЕН". При необходимости она может быть перемещена или удалена.
            this.иСТОРИЯ_ЦЕНTableAdapter.Fill(this.bikinaDataSet.ИСТОРИЯ_ЦЕН);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bikinaDataSet.ИСТОРИЯ_ЦЕН". При необходимости она может быть перемещена или удалена.
            this.пАРТНЕРЫTableAdapter.Fill(this.bikinaDataSet.ПАРТНЕРЫ);

        }

    }
}
