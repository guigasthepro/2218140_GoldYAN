// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace GoldYAN.Pages.Produtos
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Controller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Produtos\Vprodutos.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/vprodutos")]
    public partial class Vprodutos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 217 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Produtos\Vprodutos.razor"
       
    Data.CabecalhoProdutos CCP = new CabecalhoProdutos();
    Data.Servicos servicos = new Servicos();
    Data.Produtos produtos = new Produtos();
    Data.CabecalhosModelos cm = new CabecalhosModelos();
    Data.Colaboradores cl = new Colaboradores();
    Data.TipoDePeca dtdp = new TipoDePeca();
    Data.TipoProduto dtp = new TipoProduto();
    Data.Produtos cp = new Produtos();
    Data.Fornecedores fornecedores = new Data.Fornecedores();
    Data.ClassificacaoProdutos ecp = new Data.ClassificacaoProdutos();
    Data.Unidades unidade = new Data.Unidades();


    List<Unidades> listaUnidades = new List<Unidades>();
    List<ClassificacaoProdutos> listaClassificacaoProdutos = new List<ClassificacaoProdutos>();
    List<Fornecedores> listaFornecedores = new List<Fornecedores>();
    List<Servicos> ListaServicos = new List<Servicos>();
    List<TipoDePeca> listaTipoDePecas = new List<TipoDePeca>();
    List<TipoProduto> listaTipoProdutos = new List<TipoProduto>();
    List<CabecalhoProdutos> listaCabecalhoProdutos = new List<CabecalhoProdutos>();
    List<Data.Produtos> listaProdutos = new List<Produtos>();
    List<CabecalhosModelos> listacabecalhoModeloControllers = new List<CabecalhosModelos>();
    List<Colaboradores> colaboradores = new List<Colaboradores>();

    //For input values
    List<Data.Produtos> LCP = new List<Produtos>();

    bool FichaModelo = false;

    bool showModal = false;
    bool Readonly = true;
    bool ReadonlyCabecalho = true;
    int i;
    string formadepesquisa;
    public string Filter { get; set; }


    protected override async Task OnInitializedAsync()
    {
        listaCabecalhoProdutos = CAPC.GetAll();
        listaFornecedores = FC.GetAll();
        listacabecalhoModeloControllers = CMC.GetAll();
        listaClassificacaoProdutos = CPC.GetAll();
        listaUnidades = UC.GetAll();
        listaTipoDePecas = TPC.GetAll();
        listaTipoProdutos = TPRC.GetAll();
        ListaServicos = SC.GetAll();
        listaCabecalhoProdutos = CAPC.GetAll();


    }

    public bool IsVisible(CabecalhoProdutos produtos)
    {
        if (string.IsNullOrEmpty(Filter))
            return true;

        if (produtos.idproduto.Equals(Filter) || produtos.descricao.ToString().Contains(Filter) || produtos.descricao.ToUpper().Contains(Filter))
            return true;

        return false;
    }

    public void OpenFichaProduto(int id)
    {
        CCP = CAPC.Get(id);
        unidade = UC.Get(CCP.idunidade);
        ecp = CPC.Get(CCP.idclassificação);
        dtp = TPRC.Get(CCP.idtipodeproduto);
        dtdp = TPC.Get(CCP.idtipodepeca);
        if(CCP.idfornecedor.HasValue)
        {
            fornecedores = FC.Get(CCP.idfornecedor.Value);
        }
        LCP = PC.GetAllQuery(CCP.idproduto);
        
        listaProdutos = PC.GetAllQuery(id);
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

    public async Task AdicionarComposto()
    {

        if (servicos.idservico != 0)
        {
            i++;
            cp.linha = i;
            cp.custo = cl.valor;
            cp.idcolaborador = cl.idcolaborador;
            cp.idservico = servicos.idservico;
            cp.descricao = servicos.descricao;
            cp.datacriacao = DateTime.Now.ToString();

            LCP.Add(cp);

            cm = new CabecalhosModelos();
            servicos = new Servicos();
            produtos = new Produtos();
            cl = new Colaboradores();
            unidade = new Unidades();
            ecp = new ClassificacaoProdutos();

        }
        else if (produtos.idproduto != 0)
        {
            i++;
            cp.linha = i;
            cp.custo = cl.valor;
            cp.idcolaborador = cl.idcolaborador;
            cp.idproduto = produtos.idproduto;
            cp.descricao = produtos.descricao;
            cp.datacriacao = DateTime.Now.ToString();

            LCP.Add(cp);

            cm = new CabecalhosModelos();
            servicos = new Servicos();
            produtos = new Produtos();
            cl = new Colaboradores();
            unidade = new Unidades();
            ecp = new ClassificacaoProdutos();

        }
        else
        {
            await js.InvokeVoidAsync("alert", "Impossivél adicionar, por favor verifique os campos!");
        }

    }

    public async Task EditarProduto()
    {
        //Vai buscar o utilizador que está logado
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;
        CCP.idmodelo = cm.idmodelo;
        CCP.idclassificação = ecp.IDClassificacao;
        CCP.idunidade = unidade.idunidade;
        CCP.idtipodeproduto = dtp.idtipoproduto;
        CCP.idtipodepeca = dtdp.idpeca;
        CCP.idfornecedor = fornecedores.idfornecedor;


        var resultado = CAPC.Put(CCP.idproduto, CCP);
        await Task.Delay(1000);


        servicos = new Servicos();
        produtos = new Produtos();
        cl = new Colaboradores();
        CCP = new CabecalhoProdutos();
        cm = new CabecalhosModelos();
        dtp = new TipoProduto();
        dtdp = new TipoDePeca();
        LCP = new List<Produtos>();
        Readonly = true;
        StateHasChanged();
        OnInitializedAsync();
        showModal = false;
    }

    public async Task LoadData(int linha)
    {

        //m = listaProdutos[linha - 1];

        //js.InvokeVoidAsync("console.log", $"{m}");


        //if (m.idmolde.HasValue)
        //{
        //    mlds = MoldesController.Get(m.idmolde.Value);

        //}
        //else if (m.idservico.HasValue)
        //{
        //    servicos = SC.Get(m.idservico.Value);
        //}
        //else if (m.idproduto != 0)
        //{
        //    //mlds = .Get(m.idmolde.Value);
        //}
        //cl = colaboradoresController.Get(m.idcolaborador);

    }

    public async Task Apagar(int id)
    {
        //bool confirmation;

        //confirmation = await js.InvokeAsync<bool>("confirm", "Quer mesmo apagar?");

        //if (confirmation)
        //{
        //    string message = CMC.Delete(id);
        //    message += MC.Delete(id);
        //    OnInitializedAsync();
        //    Task.Delay(1000);
        //    {
        //        await js.InvokeVoidAsync("alert", @message);
        //    }
        //}
    }

    public async Task Update()
    {
        LCP.RemoveAt(cp.linha);
        LCP.Insert(cp.linha, cp);
        PC.Put(cp.idproduto, cp.linha, cp);
    }

    public async Task LoadModeloData()
    {
        if (cm.idmodelo.Length > 0)
        {
            var res = CMC.Get(cm.idmodelo);

            dtdp = TPC.Get(res.idtipodepeca.Value);
            dtp = TPRC.Get(res.idtipoproduto.Value);
            CCP.descricao = res.descricao;
        }
    }

    private async Task<IEnumerable<Unidades>> ProcurarUnidades(string searchText)
    {
        return await Task.FromResult(listaUnidades.Where(h => h.indice.ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower())).ToList());
    }

    private async Task<IEnumerable<ClassificacaoProdutos>> ProcurarClassificação(string searchText)
    {
        return await Task.FromResult(listaClassificacaoProdutos.Where(h => h.codigoat.ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower())).ToList());
    }

    private async Task<IEnumerable<TipoDePeca>> ProcurarPecas(string searchText)
    {
        return await Task.FromResult(listaTipoDePecas.Where(h => h.codigo.ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower()) || h.idpeca.ToString().Contains(searchText.ToLower())).ToList());
    }

    private async Task<IEnumerable<Fornecedores>> ProcurarFornecedores(string searchText)
    {
        return await Task.FromResult(listaFornecedores.Where(h => h.codigo.ToLower().Contains(searchText.ToLower()) || h.nome.ToLower().Contains(searchText.ToLower()) || h.nomevendedor.ToString().Contains(searchText.ToLower())).ToList());
    }

    private async Task<IEnumerable<Servicos>> ProcurarServicos(string searchText)
    {
        return await Task.FromResult(ListaServicos.Where(h => h.codigo.ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower())).ToList());
    }

    private async Task<IEnumerable<TipoProduto>> ProcurarTipoProdutos(string searchText)
    {
        return await Task.FromResult(listaTipoProdutos.Where(h => h.codigo.ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower())).ToList());
    }

    private async Task<IEnumerable<CabecalhoProdutos>> ProcurarProdutos(string searchText)
    {
        return await Task.FromResult(listaCabecalhoProdutos.Where(h => h.descricao.ToLower().Contains(searchText.ToLower()) || h.idproduto.Equals(searchText.ToLower())).ToList());
    }

    private async Task<IEnumerable<Colaboradores>> ProcurarColaboradores(string searchText)
    {
        return await Task.FromResult(colaboradores.Where(h => h.codigo.ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower())).ToList());
    }

    private async Task<IEnumerable<CabecalhosModelos>> ProcurarModelos(string searchText)
    {
        return await Task.FromResult(listacabecalhoModeloControllers.Where(h => h.idmodelo.ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower())).ToList());
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
