//Lista simplemente enlazada y lista doblemente enlazada. Desarrollar un administrador de tarea similar a una aplicacion de productividad


namespace Proyecto6_Tareas
{
    public class Tarea
    {
        public int id { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }

        public Tarea(int id, string descripcion)
        {
            this.id = id;
            Descripcion = descripcion;
            Estado = "Pendiente";
        }

        public override string ToString()
        {
            return $"{id} - {Descripcion} - {Estado}";
        }
    }
}