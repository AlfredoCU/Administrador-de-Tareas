using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorTareas
{
    class Procesos
    {
        // Atributos.
        private string nombre;
        private int pid;
        private string estado;
        private string nombreUsuario;
        private double cpu;
        private double memoria;
        private double disco;
        private string descripcion;

        // Contructores;
        public Procesos() { }
        public Procesos(string nombre, int pid, string estado, string nombreUsuario, double cpu, double memoria, double disco, string descripcion)
        {
            this.nombre = nombre;
            this.pid = pid;
            this.estado = estado;
            this.nombreUsuario = nombreUsuario;
            this.cpu = cpu;
            this.memoria = memoria;
            this.disco = disco;
            this.descripcion = descripcion;
        }

        // Métodos get y set.
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int PID
        {
            get { return pid; }
            set { pid = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string Usuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        public double CPU
        {
            get { return cpu; }
            set { cpu = value; }
        }

        public double Memoria
        {
            get { return memoria; }
            set { memoria = value; }
        }

        public double Disco
        {
            get { return disco; }
            set { disco = value; }
        }

        public string Descripción
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
    }
}
