using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocalizationTest.Resources;

namespace LocalizationTest
{
    /// <summary>
    ///     Translate Extension, to be used in the XAML when displaying text.
    /// </summary>
    /// <seealso cref="IMarkupExtension" />
    [ContentProperty("Text")]
    public class TranslateExtension : IMarkupExtension
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the Text to translate.
        /// </summary>
        public virtual string Text { get; set; }

        #endregion

        #region Methods

        /// <summary>
        ///     Returns the translated string.
        /// </summary>
        /// <param name="serviceProvider">Service Provider</param>
        /// <returns>
        ///     Translated string.
        /// </returns>
        public virtual object ProvideValue(IServiceProvider serviceProvider)
        {
            var translation = TextResources.ResourceManager.GetString(Text);

            return string.IsNullOrWhiteSpace(translation) ? string.Empty : translation;
        }

        #endregion
    }
}
