using Microsoft.EntityFrameworkCore;

namespace odec.Server.Model.HtmlElements
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="THtmlAttributeName">type of Html Attribute Name</typeparam>
    public interface IHtmlAttributesNamesContext<THtmlAttributeName> where THtmlAttributeName : class
    {
        /// <summary>
        /// Names of html attributes like id,name etc
        /// </summary>
        DbSet<THtmlAttributeName> HtmlAttributeNames { get; set; }
    }
}
