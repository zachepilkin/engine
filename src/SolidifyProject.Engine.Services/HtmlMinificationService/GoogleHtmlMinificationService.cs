﻿using System;
using System.Threading.Tasks;
using SolidifyProject.Engine.Infrastructure.Services;
using ZetaProducerHtmlCompressor.Internal;

namespace SolidifyProject.Engine.Services.HtmlMinificationService
{
    public class GoogleHtmlMinificationService : IHtmlMinificationService
    {
        private readonly HtmlCompressor _compressor;

        public GoogleHtmlMinificationService()
        {
            _compressor = new HtmlCompressor();
            
            _compressor.setEnabled(true);
            _compressor.setRemoveComments(true);
            _compressor.setRemoveMultiSpaces(true);
            _compressor.setRemoveIntertagSpaces(true);
        }
        
        public async Task<string> CompressHtmlAsync(string html)
        {
            if (html == null)
            {
                throw new ArgumentNullException(nameof(html));
            }

            return _compressor.compress(html);
        }
    }
}