// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace GoldYAN.Pages.Encomendas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Encomendas\Cencomenda.razor"
using GoldYAN.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Encomendas\Cencomenda.razor"
using GoldYAN.Controller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Encomendas\Cencomenda.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Encomendas\Cencomenda.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Encomendas\Cencomenda.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Encomendas\Cencomenda.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/cencomenda")]
    public partial class Cencomenda : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 288 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Encomendas\Cencomenda.razor"
       

    Data.Servicos servicos = new Servicos();
    Data.Encomendas encomendas = new Encomendas();
    Clientes Cliente = new Clientes();
    Data.Cabecalho cabecalhos = new Cabecalho();
    List<Encomendas> ListaEncomendas = new List<Encomendas>();
    List<Cabecalho> ListaCabecalhos = new List<Cabecalho>();
    List<Servicos> ListaServicos = new List<Servicos>();
    List<Clientes> ListaClientes = new List<Clientes>();
    bool Readonly = true;
    int i;
    bool showModal = false;


    protected override async Task OnInitializedAsync()
    {

        //Cleaning Lists And Class Objects
        ListaClientes = new List<Clientes>();
        ListaServicos = new List<Servicos>();
        ListaEncomendas = new List<Encomendas>();
        Cliente = new Clientes();
        servicos = new Servicos();
        encomendas = new Encomendas();
        cabecalhos = new Cabecalho();

        Cliente.idcliente = 0;
        ListaClientes = CC.Get();
        ListaServicos = SC.GetAll();
        servicos.idservico = 0;
        encomendas.datadeentrega = DateTime.Today;
    }

    private async Task<IEnumerable<Clientes>> ProcurarClientes(string searchText)
    {
        return await Task.FromResult(ListaClientes.Where(h => h.Nome.ToLower().Contains(searchText.ToLower()) || h.Telefone.ToLower().Contains(searchText.ToLower()) || h.Email.ToLower().Contains(searchText.ToLower()) || h.Morada.ToLower().Contains(searchText.ToLower())));
    }

    private async Task<IEnumerable<Servicos>> ProcurarServicos(string searchText)
    {
        encomendas.quantidade = 1;
        return await Task.FromResult(ListaServicos.Where(h => h.codigo.ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower())).ToList());
    }



    private async Task AdicionarLista()
    {
        if (servicos.idservico == 0)
        {
            await js.InvokeVoidAsync("alert", "Impossivél adicionar o serviço, por favor verifique os campos!");
        }
        else
        {
            i++;

            cabecalhos.idcliente = Cliente.idcliente;
            encomendas.linha = i;
            encomendas.idservico = servicos.idservico;
            encomendas.descricao = servicos.descricao;
            encomendas.codigo = servicos.codigo;
            encomendas.precounitario = servicos.custo;
            encomendas.precototal = encomendas.precounitario * encomendas.quantidade;

            //Vai buscar o utilizador que está logado
            var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;
            cabecalhos.criadopor = user.Identity.Name;

            ListaEncomendas.Add(encomendas);


            encomendas = new Encomendas();
            servicos = new Servicos();
            encomendas.datadeentrega = DateTime.Today;
        }

    }

    public async Task CriarEncomenda()
    {
        if (ListaEncomendas.Count != 0)
        {
            var resultado = CEC.Post(cabecalhos);
            await Task.Delay(1000);

            for (int i = 0; i < ListaEncomendas.Count; i++)
            {
                ListaEncomendas[i].idencomenda = resultado.idencomenda;
                EC.Post(ListaEncomendas[i]);
            }
            StateHasChanged();
            OnInitializedAsync();
        }
        else
        {
            await js.InvokeVoidAsync("alert", "Impossível criar a encomenda, por favor, insira bem os dados da encomenda!");
        }



    }

    public async Task EditarEncomenda(int linha)
    {
        servicos = SC.Get(ListaEncomendas[linha - 1].idservico);
        encomendas = ListaEncomendas[linha - 1];
        showModal = true;
    }

    public async Task AtualizarLista()
    {
        encomendas.idservico = servicos.idservico;
        encomendas.descricao = servicos.descricao;
        encomendas.codigo = servicos.codigo;
        encomendas.precounitario = servicos.custo;
        encomendas.precototal = encomendas.precounitario * encomendas.quantidade;

        ListaEncomendas.RemoveAt(encomendas.linha - 1);
        ListaEncomendas.Insert(encomendas.linha - 1, encomendas);
        showModal = false;
    }

    public async Task Apagar(int linha)
    {
        ListaEncomendas.RemoveAt(linha - 1);
    }

    public async Task ModalCancel()
    {
        showModal = false;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CabecalhoController CEC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EncomendasController EC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicosController SC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClientesController CC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TipodeCompraController TCC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HistoricoStockController hStockC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LocalizacaoController LocalizacaoC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EstadosController EstadosC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ComprasController ComprasC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CabecalhoComprasController CComprasC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FabricoController FBCC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CabecalhoFabricoController CFC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClassificacaoProdutosController CPC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UnidadesController UC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BancosController VB { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProfissoesController ProfissaoC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MateriasController MateriasC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MoldesController MoldesController { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FornecedoresController FC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TipoProdutoController TPRC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TipoPecaController TPC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ModelosController MC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProdutosController PC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CabecalhoController CabecalhoEncomendasC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CabecalhoProdutosController CAPC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ColaboradoresController colaboradoresController { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CabecalhoModeloController CMC { get; set; }
    }
}
#pragma warning restore 1591
