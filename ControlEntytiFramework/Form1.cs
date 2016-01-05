using ControlEntityFrameowrk.Servicos.Classes;
using ControlEntityFramework.Data.IRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlEntytiFramework
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      Repository<Clientes> myReposotiry =  new Repository<Clientes>();

      var x = myReposotiry.GetAll<Clientes>().ToList();
    }
  }
}
