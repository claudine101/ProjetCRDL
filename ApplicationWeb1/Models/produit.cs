//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApplicationWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class produit
    {
        public int ID { get; set; }
        public Nullable<int> categorieId { get; set; }
        public string NomProduit { get; set; }
    
        public virtual categorie categorie { get; set; }
    }
}
