// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace GoldYAN.Pages.Modelos
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Modelos\Vmodelo.razor"
using GoldYAN.Controller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Modelos\Vmodelo.razor"
using GoldYAN.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Modelos\Vmodelo.razor"
using Microsoft.EntityFrameworkCore.Internal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Modelos\Vmodelo.razor"
           [Authorize(Roles = "Admin, Dev, Contabilidade")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/vmodelo")]
    public partial class Vmodelo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 339 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Modelos\Vmodelo.razor"
       


    // Invoking classes
    Data.Servicos servicos = new Servicos();
    Data.Moldes mlds = new Moldes();
    Data.Produtos produtos = new Produtos();
    Data.CabecalhosModelos cm = new CabecalhosModelos();
    Data.Modelos m = new Modelos();
    Data.Colaboradores cl = new Colaboradores();
    Data.TipoDePeca dtdp = new TipoDePeca();
    Data.TipoProduto dtp = new TipoProduto();



    //Invoking lists
    List<Servicos> ListaServicos = new List<Servicos>();
    List<CabecalhoProdutos> listaCProdutos = new List<CabecalhoProdutos>();
    List<Moldes> listaMoldes = new List<Moldes>();
    List<TipoDePeca> listaTipoDePecas = new List<TipoDePeca>();
    List<TipoProduto> listaTipoProdutos = new List<TipoProduto>();
    List<Modelos> listaModelos = new List<Modelos>();
    List<Colaboradores> colaboradores = new List<Colaboradores>();
    List<Modelos> mo = new List<Modelos>();

    bool FichaModelo = false;

    bool showModal = false;
    bool showModal2 = false;
    bool Readonly = true;
    bool ReadonlyCabecalho = true;
    int i;
    string formadepesquisa;


    Data.CabecalhosModelos updateCm = new CabecalhosModelos();
    Data.Modelos updateM = new Modelos();

    List<CabecalhosModelos> LCM = new List<CabecalhosModelos>();
    List<Modelos> LM = new List<Modelos>();

    public string Filter { get; set; }

    protected override async Task OnInitializedAsync()
    {
        LCM = CMC.GetAll();


        colaboradores = colaboradoresController.GetAll();
        listaMoldes = MoldesController.Get();
        listaTipoDePecas = TPC.GetAll();
        listaTipoProdutos = TPRC.GetAll();
        listaCProdutos = CAPC.GetAll();
        ListaServicos = SC.GetAll();
    }

    public bool IsVisible(CabecalhosModelos cmodelos)
    {
        if (string.IsNullOrEmpty(Filter))
            return true;

        if (cmodelos.descricao.Contains(Filter) || cmodelos.idmodelo.ToString().Contains(Filter) || cmodelos.criadopor.ToString().Contains(Filter) || cmodelos.datacriacao.ToString().Contains(Filter))
            return true;

        return false;
    }

    public void OpenFichaModelo(string id)
    {
        cm = CMC.Get(id);
        dtp = TPRC.Get(cm.idtipoproduto.Value);
        dtdp = TPC.Get(cm.idtipodepeca.Value);
        listaModelos = MC.GetAllQuery(id);
        showModal = true;
    }
    void ModalShow()
    {
        showModal = true;
    }
    void ModalCancel()
    {
        showModal = false;
    }

    public async Task AtualizarLista()
    {
        var resultado = CMC.Put(cm.idmodelo, cm);
        if (resultado != null)
        {
            js.InvokeVoidAsync("alert", "Cabeçalho atualizado com sucesso!");
        }
        else
        {
            js.InvokeVoidAsync("alert", "Cabeçalho não foi atualizado com sucesso!");

        }
    }

    public async Task LoadData(string id, int linha)
    {

        m = listaModelos[linha - 1];

        js.InvokeVoidAsync("console.log", $"{m}");


        if (m.idmolde.HasValue)
        {
            mlds = MoldesController.Get(m.idmolde.Value);

        }
        else if (m.idservico.HasValue)
        {
            servicos = SC.Get(m.idservico.Value);
        }
        else if (m.idproduto != 0)
        {
            //mlds = .Get(m.idmolde.Value);
        }
        cl = colaboradoresController.Get(m.idcolaborador);

    }

    public async Task Apagar(string id)
    {
        bool confirmation;

        confirmation = await js.InvokeAsync<bool>("confirm", "Quer mesmo apagar?");

        if (confirmation)
        {
            string message = CMC.Delete(id);
            message += MC.Delete(id);
            OnInitializedAsync();
            Task.Delay(1000);
            {
                await js.InvokeVoidAsync("alert", @message);
            }
        }
    }

    public async Task Update(string id, int linha)
    {

        listaModelos.RemoveAt(linha - 1);
        listaModelos.Insert(linha - 1, m);

        var resultado = MC.Put(id, linha, m);
        if (resultado != null)
        {
            js.InvokeVoidAsync("alert", "Cabeçalho atualizado com sucesso!");
        }
        else
        {
            js.InvokeVoidAsync("alert", "Cabeçalho não foi atualizado com sucesso!");

        }
    }

    private async Task<IEnumerable<TipoDePeca>> ProcurarPecas(string searchText)
    {
        return await Task.FromResult(listaTipoDePecas.Where(h => h.codigo.ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower()) || h.idpeca.ToString().Contains(searchText.ToLower())).ToList());
    }

    private async Task<IEnumerable<Moldes>> ProcurarMoldes(string searchText)
    {
        return await Task.FromResult(listaMoldes.Where(h => h.codigo.ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower()) || h.idmolde.ToString().Contains(searchText.ToLower())).ToList());
    }

    private async Task<IEnumerable<Servicos>> ProcurarServicos(string searchText)
    {
        return await Task.FromResult(ListaServicos.Where(h => h.codigo.ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower())).ToList());
    }

    private async Task<IEnumerable<TipoProduto>> ProcurarTipoProdutos(string searchText)
    {
        return await Task.FromResult(listaTipoProdutos.Where(h => h.codigo.ToString().ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower())).ToList());
    }

    private async Task<IEnumerable<CabecalhoProdutos>> ProcurarProdutos(string searchText)
    {
        return await Task.FromResult(listaCProdutos.Where(h => h.idproduto.ToString().ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower())).ToList());
    }

    private async Task<IEnumerable<Colaboradores>> ProcurarColaboradores(string searchText)
    {
        return await Task.FromResult(colaboradores.Where(h => h.codigo.ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower())).ToList());
    }


#line default
#line hidden
#nullable disable
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EncomendasController EC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClientesController CC { get; set; }
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicosController SC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
