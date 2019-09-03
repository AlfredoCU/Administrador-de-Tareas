using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorTareas
{
    class ListaProcesos
    {
        // Instancia.
        private List<Procesos> pro = new List<Procesos>();

        // Constructor.
        public ListaProcesos() { }

        // Métodos get y set.
        public List<Procesos> ProcesosLista
        {
            get { return pro; }
            set { pro = value; }
        }

        // Ingresar datos a la lista.
        public void InsertarLista(Procesos datos)
        {
            ProcesosLista.Add(datos);
        }

        // Mostrar la lista.
        public List<Procesos> MostrarLista()
        {
            return ProcesosLista;
        }

        // Buscar datos en la lista.
        public bool BuscarLista(int id)
        {
            bool find = false;
            foreach (var data in ProcesosLista)
            {
                if (data.PID == id)
                {
                    find = true;
                }
                else
                {
                    find = false;
                }
            }
            return find;
        }

        // Eliminar un dato de la lista.
        public void EliminarDatoLista(int id)
        {
            foreach (var data in ProcesosLista)
            {
                if (data.PID == id)
                {
                    ProcesosLista.Remove(data);
                    break;
                }
            }
        }

        // Reiniciar la lista.
        public void ReiniciarLista()
        {
            ProcesosLista.Clear();
        }

        // Muestra el total de procesos.
        public int Total()
        {
            return ProcesosLista.Count();
        }

        // Iniciar lista con datos.
        public void IniciaLista()
        {
            Random num = new Random();
            Procesos dt1 = new Procesos("explorer.exe", 16240, "Ejecutando", "Alfredo", num.Next(0, 20), num.Next(1, 300), num.Next(0, 10), "Explorador de Windows", 60);
            ProcesosLista.Add(dt1);
            Procesos dt2 = new Procesos("System", 4, "Ejecutando", "SYSTEM", num.Next(0, 20), num.Next(1, 300), num.Next(0, 10), "NT kernel & System", 35);
            ProcesosLista.Add(dt2);
            Procesos dt3 = new Procesos("Spotify.exe", 17996, "Ejecutando", "Alfredo", num.Next(0, 20), num.Next(1, 300), num.Next(0, 10), "Spotify", 40);
            ProcesosLista.Add(dt3);
            Procesos dt4 = new Procesos("avp.exe", 3000, "Ejecutando", "SYSTEM", num.Next(0, 20), num.Next(1, 300), num.Next(0, 10), "Kaspersky Anti-Virus", 65);
            ProcesosLista.Add(dt4);
            Procesos dt5 = new Procesos("audiodg.exe", 27972, "Ejecutando", "SERVICIO LOCAL", num.Next(0, 20), num.Next(1, 300), num.Next(0, 10), "Aislamiento de gráficos de dispositivo de audio de Windows", 60);
            ProcesosLista.Add(dt5);
            Procesos dt6 = new Procesos("SearchUI.exe", 14356, "Ejecutando", "Alfredo", num.Next(0, 20), num.Next(1, 300), num.Next(0, 10), "Search and Cortana application", 60);
            ProcesosLista.Add(dt6);
            Procesos dt7 = new Procesos("SkypeApp.exe", 5472, "Ejecutando", "Alfredo", num.Next(0, 20), num.Next(1, 300), num.Next(0, 10), "SkypeApp", 42);
            ProcesosLista.Add(dt7);
            Procesos dt8 = new Procesos("CCleaner64.exe", 7476, "Ejecutando", "Alfredo", num.Next(0, 20), num.Next(1, 300), num.Next(0, 10), "CCleaner", 50);
            ProcesosLista.Add(dt8);
            Procesos dt9 = new Procesos("explorer.exe", 21048, "Ejecutando", "Alfredo", num.Next(0, 20), num.Next(1, 300), num.Next(0, 10), "Google Chrome", 30);
            ProcesosLista.Add(dt9);
            Procesos dt10 = new Procesos("AppleMobileDeviceService.exe", 36600, "Ejecutando", "SYSTEM", num.Next(0, 20), num.Next(1, 300), num.Next(0, 10), "MobileDeviceService", 20);
            ProcesosLista.Add(dt10);
            Procesos dt11 = new Procesos("sadwd.exe", 8546, "Ejecutando", "SYSTEM", num.Next(0, 20), num.Next(1, 300), num.Next(0, 10), "SYSTEM", 45);
            ProcesosLista.Add(dt11);
            Procesos dt12 = new Procesos("asdqs.exe", 5545, "Ejecutando", "SYSTEM", num.Next(0, 20), num.Next(1, 300), num.Next(0, 10), "SYSTEM", 21);
            ProcesosLista.Add(dt12);
            Procesos dt13 = new Procesos("erdfs.exe", 84538, "Ejecutando", "SYSTEM", num.Next(0, 20), num.Next(1, 300), num.Next(0, 10), "SYSTEM", 25);
            ProcesosLista.Add(dt13);
            Procesos dt14 = new Procesos("erds.exe", 8458, "Ejecutando", "SYSTEM", num.Next(0, 20), num.Next(1, 300), num.Next(0, 10), "SYSTEM", 40);
            ProcesosLista.Add(dt14);
            Procesos dt15 = new Procesos("fcvews.exe", 844595, "Ejecutando", "SERVICIO LOCAL", num.Next(0, 20), num.Next(1, 300), num.Next(0, 10), "SERVICIO LOCAL", 50);
            ProcesosLista.Add(dt15);
            Procesos dt16 = new Procesos("sdeed.exe", 994557, "Ejecutando", "SERVICIO LOCAL", num.Next(0, 20), num.Next(1, 300), num.Next(0, 10), "SERVICIO LOCAL", 60);
            ProcesosLista.Add(dt16);
            Procesos dt17 = new Procesos("fesd.exe", 3087, "Ejecutando", "SERVICIO LOCAL", num.Next(0, 20), num.Next(1, 300), num.Next(0, 10), "SERVICIO LOCAL", 20);
            ProcesosLista.Add(dt17);
            Procesos dt18 = new Procesos("Whatsapp.exe", 128668, "Ejecutando", "Alfredo", num.Next(0, 20), num.Next(1, 300), num.Next(0, 10), "Whatsapp", 60);
            ProcesosLista.Add(dt18);
            Procesos dt19 = new Procesos("VisualStudio.exe", 1745, "Ejecutando", "Alfredo", num.Next(0, 20), num.Next(1, 300), num.Next(0, 10), "VisualStudio", 55);
            ProcesosLista.Add(dt19);
            Procesos dt20 = new Procesos("Latex.exe", 23571, "Ejecutando", "Alfredo", num.Next(0, 20), num.Next(1, 300), num.Next(0, 10), "Texmaker", 50);
            ProcesosLista.Add(dt20);
            Procesos dt21 = new Procesos("Apex.exe", 95137, "Ejecutando", "Alfredo", num.Next(0, 20), num.Next(1, 300), num.Next(0, 10), "Apex", 20);
            ProcesosLista.Add(dt21);
        }
    }
}
