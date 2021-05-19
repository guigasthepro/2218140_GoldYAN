// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace GoldYAN.Pages.Oficina
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Oficina\Oficina.razor"
using GoldYAN.Controller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Oficina\Oficina.razor"
using GoldYAN.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Oficina\Oficina.razor"
using Microsoft.EntityFrameworkCore.Internal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Oficina\Oficina.razor"
           [Authorize(Roles = "Admin, Dev, Oficina ")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/oficina")]
    public partial class Oficina : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 134 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Oficina\Oficina.razor"
       
    List<Localizacoes> listLocalizacoes = new List<Localizacoes>();
    List<Colaboradores> listColaboradores = new List<Colaboradores>();
    List<Estados> listEstados = new List<Estados>();
    List<EncomendasComputed> VEC = new List<EncomendasComputed>();

    // Object Classes
    Data.Estados estado = new Data.Estados();
    Data.Localizacoes localizacao = new Data.Localizacoes();
    Data.Colaboradores colaboradores = new Data.Colaboradores();


    public string Filter { get; set; }
    bool showModal = false;
    int EncomendaID = 0;
    int EncomendaLinha = 0;

    protected override async Task OnInitializedAsync()
    {
        VEC = EC.GetWithInner();
        listColaboradores = colaboradoresController.GetAll();
        listEstados = EstadosC.GetAll();
        listLocalizacoes = LocalizacaoC.GetAll();
    }

    public bool IsVisible(EncomendasComputed encomendas)
    {
        if (string.IsNullOrEmpty(Filter))
            return true;

        if (encomendas.nome.Contains(Filter) || encomendas.telefone.ToString().Contains(Filter) || encomendas.idwithlinha.ToString().Contains(Filter) || encomendas.data.ToString().Contains(Filter))
            return true;

        return false;
    }

    public async Task AbrirModalOficina(int id, int linha)
    {
        EncomendaID = id;
        EncomendaLinha = linha;
        showModal = true;
    }

    public async Task FecharModal()
    {
        showModal = false;
    }

    public async Task AtribuirColaborador()
    {
        if (localizacao != null)
        {
            var resultado1 = EC.LancarLocalizacoes(EncomendaID, EncomendaLinha, localizacao.descricao);

        }
        if (estado != null)
        {
            var resultado2 = EC.LancarEstado(EncomendaID, EncomendaLinha, estado.descricao);
        }
        if (colaboradores != null)
        {
            var resultado3 = EC.AtribuirColaborador(EncomendaID, EncomendaLinha, colaboradores.descricao);

        }
    }

    private async Task<IEnumerable<Colaboradores>> ProcurarColaborador(string searchText)
    {
        return await Task.FromResult(listColaboradores.Where(h => h.idcolaborador.ToString().ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower())).ToList());
    }

    private async Task<IEnumerable<Localizacoes>> ProcurarLocalizacao(string searchText)
    {
        return await Task.FromResult(listLocalizacoes.Where(h => h.idlocalizacao.ToString().ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower())).ToList());
    }

    private async Task<IEnumerable<Estados>> ProcurarEstado(string searchText)
    {
        return await Task.FromResult(listEstados.Where(h => h.idestados.ToString().ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower())).ToList());
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CabecalhoController CEC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EncomendasController EC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicosController SC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClientesController CC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TipodeCompraController TCC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HistoricoStockController hStockC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LocalizacaoController LocalizacaoC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AspNetUsersController aspController { get; set; }
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
