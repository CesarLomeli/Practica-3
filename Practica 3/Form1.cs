namespace Practica_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Cargamos el archivo de procesos
            Proceso proceso = new Proceso();
            List<Proceso> procesosLst = new List<Proceso>();
            //Guardamos lista de procesos
            procesosLst = proceso.cargarProcesos("C:\\Users\\cesar\\OneDrive\\Documentos\\School\\Seminario de sistemas operativos\\Practica 3\\procesos.txt");
            foreach (var obj in procesosLst)
            {
                fileBox.Items.Add($"Proceso {obj.nombre}, Tiempo {obj.tiempo}, Prioridad {obj.prioridad}");
            }
            //Creamos objeto fifo
            Fifo fifo = new Fifo();
            var fifoItems = fifo.ejecutarFifo(procesosLst);
            foreach (var obj in fifoItems)
            {
                fifoBox.Items.Add($"{obj.nombre} Inicio {obj.inicio} Final {obj.final}");
            }
            //Creamos objeto Sjf
            Sjf sjf = new Sjf();
            var sjfList = sjf.ejecutarSjf(procesosLst);
            foreach(var obj in sjfList)
            {
                sjfBox.Items.Add($"{obj.nombre} Tiempo {obj.tiempo} Inicio {obj.inicio} Final {obj.final}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
