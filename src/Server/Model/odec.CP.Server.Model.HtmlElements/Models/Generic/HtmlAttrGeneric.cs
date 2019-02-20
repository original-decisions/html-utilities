using System.ComponentModel.DataAnnotations;
using odec.Framework.Generic;

namespace odec.Server.Model.HtmlElements.Generic
{
    /// <summary>
    /// Обобщенный класс - хтмл аттрибутов
    /// </summary>
    /// <typeparam name="TKey">Тип идентификатора</typeparam>
    public class HtmlAttrGeneric<TKey> : Glossary<TKey>
    {
        /// <summary>
        /// Имя 
        /// </summary>
        [StringLength(100)]
        public override string Name { get; set; }
    }
}
