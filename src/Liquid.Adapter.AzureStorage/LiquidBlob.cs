﻿namespace Liquid.Adapter.AzureStorage
{
    /// <summary>
    /// Set de propriedades referentes à um item do BlobStorage.
    /// </summary>
    public class LiquidBlob
    {
        /// <summary>
        /// Lista de tags referentes ao blob.
        /// </summary>
        public IDictionary<string, string>? Tags { get; set; }

        /// <summary>
        /// Conteúdo do blob.
        /// </summary>
        public string? Blob { get; set; }

        /// <summary>
        /// Nome do arquivo no Storage.
        /// </summary>
        public string Name { get; set; }
    }
}
