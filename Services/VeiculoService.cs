using System.Net.Http.Json;

namespace atividade_veiculos.Services
{
    public class VeiculoService
    {
        private readonly HttpClient _httpClient;

        public VeiculoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Obtém a lista de veículos
        public async Task<List<Veiculo>> GetVeiculos()
        {
            return await _httpClient.GetFromJsonAsync<List<Veiculo>>("veiculos");
        }

        // Obtém um veículo por ID
        public async Task<Veiculo> GetVeiculoById(int id)
        {
            return await _httpClient.GetFromJsonAsync<Veiculo>($"veiculos/{id}");
        }

        // Adiciona um novo veículo
        public async Task AddVeiculo(Veiculo novoVeiculo)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("veiculos", novoVeiculo);
                response.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao cadastrar o veículo: {ex.Message}");
            }
        }

        // Atualiza um veículo existente
        public async Task UpdateVeiculo(Veiculo veiculo)
        {
            try
            {
                var response = await _httpClient.PutAsJsonAsync($"veiculos/{veiculo.Id}", veiculo);
                response.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao editar o veículo: {ex.Message}");
            }
        }

        // Deleta um veículo
        public async Task DeleteVeiculo(int id)
        {

            try
            {
                var response = await _httpClient.DeleteAsync($"veiculos/{id}");
                response.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao deletar o veículo: {ex.Message}");
            }
        }

        // Métodos get marcas
        public async Task<List<Marca>> GetMarcas()
        {
            return await _httpClient.GetFromJsonAsync<List<Marca>>("marcas");
        }
        // Métodos get cor
        public async Task<List<Cor>> GetCores()
        {
            return await _httpClient.GetFromJsonAsync<List<Cor>>("cores");
        }
    }
}
