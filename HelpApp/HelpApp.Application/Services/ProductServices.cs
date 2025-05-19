using AutoMapper;
using HelpApp.Application.Interfaces;
using HelpApp.Domain.Interfaces;
using HelpApp.Application.DTOs;
using HelpApp.Domain.Entities;

namespace HelpApp.Application.Services
{
    internal class ProductServices : IProductService
    {
        private IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductServices(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository= productRepository;
            _mapper= mapper;
        }

        public async Task<IEnumerable<ProductDTO>> GetProducts()
        {
            var productEntity = await _productRepository.GetProducts();
            return _mapper.Map<IEnumerable<ProductDTO>>(productEntity);
        }

        public async Task<ProductDTO> GetById(int ? id)
        {
            var productEntity = await _productRepository.GetById(id);
            return _mapper.Map<ProductDTO>(productEntity);
        }

        public async Task Add(ProductDTO productDto)
        {
            var productEntity = _mapper.Map<Product>(productDto);
            await _productRepository.Create(productEntity);
        }

        public async Task Update(ProductDTO productDto)
        {
            var productEntity = _mapper.Map<Product>(productDto);
            await _productRepository.Update(productEntity);
        }

        public async Task Remove(int? id)
        {
            var productEntity = _productRepository.GetById(id).Result;
            await _productRepository.Update(productEntity);
        }
    }
}
