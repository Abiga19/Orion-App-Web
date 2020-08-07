//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace calypso_app.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class procesador
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public procesador()
        {
            this.paquete_ensamble = new HashSet<paquete_ensamble>();
        }
    
        public int id_procesador { get; set; }
        public string nombre_procesador { get; set; }
        public string descripcion_procesador { get; set; }
        public string modelo_procesador { get; set; }
        public int nucleos_procesador { get; set; }
        public Nullable<decimal> frecuencia_procesador { get; set; }
        public int tipomemoria_procesador { get; set; }
        public int tiposocket_procesador { get; set; }
        public bool graficos { get; set; }
        public Nullable<int> generacion_procesador { get; set; }
        public string familia_procesador { get; set; }
        public bool estatus_procesador { get; set; }
        public int id_inventario { get; set; }
    
        public virtual inventario inventario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<paquete_ensamble> paquete_ensamble { get; set; }
        public virtual tipo_memoria tipo_memoria { get; set; }
        public virtual tipo_socket tipo_socket { get; set; }
    }
}
