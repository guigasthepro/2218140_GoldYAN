// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace GoldYAN.Pages.Compras
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
#line 3 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

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
#line 12 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Controller;

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
#line 3 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Compras\Vcompras.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/vcompras")]
    public partial class Vcompras : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 263 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Compras\Vcompras.razor"
       

    List<CabecalhoProdutos> listaCabecalhoProdutos = new List<CabecalhoProdutos>();
    List<Colaboradores> colaboradores = new List<Colaboradores>();
    List<CabecalhoCompras> listaCCompras = new List<CabecalhoCompras>();
    List<Compras> listaCompras = new List<Compras>();


    //Declaration of needed objects
    Data.CabecalhoProdutos CCP = new CabecalhoProdutos();
    Data.Colaboradores cl = new Colaboradores();
    Data.TipoDePeca dtdp = new TipoDePeca();
    Data.TipoProduto dtp = new TipoProduto();
    Data.Fornecedores fornecedores = new Data.Fornecedores();
    Data.ClassificacaoProdutos ecp = new Data.ClassificacaoProdutos();
    Data.CabecalhoCompras CCompra = new Data.CabecalhoCompras();
    Data.Compras Compra = new Data.Compras();
    Data.IDMaximo IDMaximo = new Data.IDMaximo();
    Data.HistoricoStock hStock = new Data.HistoricoStock();
    Data.TipodeCompra TDC = new TipodeCompra();


    // Declaration of needed lists
    List<Unidades> listaUnidades = new List<Unidades>();
    List<ClassificacaoProdutos> listaClassificacaoProdutos = new List<ClassificacaoProdutos>();
    List<Fornecedores> listaFornecedores = new List<Fornecedores>();
    List<TipoDePeca> listaTipoDePecas = new List<TipoDePeca>();
    List<TipoProduto> listaTipoProdutos = new List<TipoProduto>();
    List<CabecalhoProdutos> listaCabecalhoProduto = new List<CabecalhoProdutos>();
    List<TipodeCompra> LTDC = new List<TipodeCompra>();
    List<HistoricoStock> LHS = new List<HistoricoStock>();







    //For input values
    List<Data.CabecalhoProdutos> LCP = new List<CabecalhoProdutos>();
    List<Data.Compras> LC = new List<Data.Compras>();

    bool FichaModelo = false;

    bool showModal = false;
    bool Readonly = true;
    bool ReadonlyCabecalho = true;
    int i;
    bool save = false;
    public string Filter { get; set; }
    bool ProdutoNovo = true;
    ActionResult<CabecalhoCompras> RCCompra = new CabecalhoCompras();
    public int linhaselecionada { get; set; }
    public double custototalsomado { get; set; }

    protected override async Task OnInitializedAsync()
    {
        listaCCompras = CComprasC.GetAll();
        listaFornecedores = FC.GetAll();
        listaClassificacaoProdutos = CPC.GetAll();
        listaUnidades = UC.GetAll();
        listaTipoDePecas = TPC.GetAll();
        listaTipoProdutos = TPRC.GetAll();
        listaCabecalhoProduto = CAPC.GetAll();
        LTDC = TCC.GetAll();
    }

    public bool IsVisible(CabecalhoCompras compras)
    {
        if (string.IsNullOrEmpty(Filter))
            return true;

        if (compras.apontamentos.Equals(Filter) || compras.idcompra.ToString().Contains(Filter) || compras.idfornecedor.ToString().Contains(Filter))
            return true;

        return false;
    }

    public bool IsVisibleProdutos(CabecalhoProdutos produtos)
    {
        if (string.IsNullOrEmpty(Filter))
            return true;

        if (produtos.idproduto.Equals(Filter) || produtos.descricao.ToString().Contains(Filter) || produtos.apontamentos.ToString().Contains(Filter))
            return true;

        return false;
    }

    public async Task OpenFichaProduto(int idproduto, int linha)
    {
        linhaselecionada = linha;


        CCP = LCP[linha - 12];
        dtp = TPRC.Get(CCP.idtipodeproduto);
        dtdp = TPC.Get(CCP.idtipodepeca);
        ecp = CPC.Get(CCP.idclassificação);
        LHS = hStockC.GetAllQuery(CCompra.idcompra, idproduto);
        Compra = ComprasC.GetOneLine(CCompra.idcompra, CCP.idproduto, linha + 1);


    }

    public void AbrirModal(int id)
    {
        i++;
        LCP = new List<CabecalhoProdutos>();
        listaCompras = ComprasC.GetAllQuery(id);
        CCompra = CComprasC.Get(id);
        fornecedores = FC.Get(CCompra.idfornecedor);


        foreach (var compra in listaCompras)
        {
            CCP = CAPC.Get(compra.idproduto);
            CCP.linha = i;
            LCP.Add(CCP);
            CCP = new CabecalhoProdutos();
        }

        showModal = true;
    }

    void ModalCancel()
    {
        showModal = false;
    }

    public async Task ApagarComposto(int i)
    {
        CCP.stock = CCP.stock - listaCompras[i - 1].quantidade;
        CAPC.Put(CCP.idproduto, CCP);
        ComprasC.Delete(LCP[i].idcompra, i - 1);
        LCP.RemoveAt(i);

    }

    public async Task EditarComposto()
    {
        CCP.idclassificação = ecp.IDClassificacao;
        CCP.idtipodeproduto = dtp.idtipoproduto;
        CCP.idtipodepeca = dtdp.idpeca;

        hStock = LHS[CCP.linha - 1];

        hStock.stockinicial = hStock.stockfinal.Value - hStock.stockadicionado;

        if (CCP.stock.HasValue)
        {
            CCP.stockantigo = CCP.stock.GetValueOrDefault();
            CCP.stock = CCP.stock - hStock.stockadicionado;

        }

        if (CCP.updatestock.HasValue)
        {
            CCP.stocktotal = CCP.stock.GetValueOrDefault() + CCP.updatestock.Value;
            Compra.quantidade = CCP.updatestock.GetValueOrDefault();
            hStock.stockadicionado = CCP.updatestock.Value;
            hStock.stockfinal = hStock.stockinicial + hStock.stockadicionado;
        }
        else if (CCP.peso.HasValue)
        {
            CCP.stocktotal = CCP.stock.GetValueOrDefault() + CCP.peso.Value;
        }
        else
        {
            js.InvokeVoidAsync("alert", "Impossivel adicionar stock ao produto, o produto foi composto sem stock!");

        }



        if (CCP.stocktotal.HasValue)
        {
            CCP.stock = CCP.stocktotal.Value;
        }




        if (CCP.peso.HasValue && CCP.cotacao.HasValue && CCP.updatestock.HasValue)
        {
            CCP.preco = (CCP.peso.Value * CCP.cotacao.Value) + CCP.feitiopeca;
            CCP.custototal = CCP.preco * CCP.updatestock;

        }
        else if (CCP.peso.HasValue && CCP.cotacao.HasValue && !CCP.updatestock.HasValue)
        {
            CCP.preco = (CCP.peso.Value * CCP.cotacao.Value) + CCP.feitiopeca;
            CCP.custototal = CCP.preco;
        }
        else if (CCP.updatestock.HasValue)
        {
            CCP.preco = CCP.feitiopeca;
            CCP.custototal = CCP.preco * CCP.updatestock;
        }
        else
        {
            js.InvokeVoidAsync("alert", "Impossivel fazer o preço, o produto foi adicionado sem preço");
        }



        if (CCP.preco.HasValue)
        {
            Compra.preco = CCP.preco.Value;
        }


        LCP.RemoveAt(CCP.linha -1);
        LCP.Insert(CCP.linha - 1, CCP);
        CAPC.Put(CCP.idproduto, CCP);
        ComprasC.Put(Compra.idcompra, Compra.linha, Compra);
        hStockC.Put(hStock.id, hStock);

    }


    public async Task EditarCabecalho()
    {
        CCompra.idfornecedor = fornecedores.idfornecedor;
        CCompra.idtipodecompra = TDC.idtipocompra;
        RCCompra = CComprasC.Put(CCompra.idcompra, CCompra);
    }

    // Function that does the selecting in the selected buttons
    public async Task CriarProdutoNovo()
    {
        CCP = new CabecalhoProdutos();
        ProdutoNovo = true;
        CCP.produtonovo = true;
        CCP.produtonovo = true;
    }

    public async Task Apagar(int id)
    {
        bool confirmation;

        confirmation = await js.InvokeAsync<bool>("confirm", "Quer mesmo apagar?");

        if (confirmation)
        {
            string message = CComprasC.Delete(id);
            message += ComprasC.DeleteAll(id);
            OnInitializedAsync();
            Task.Delay(1000);
            {
                await js.InvokeVoidAsync("alert", @message);
            }
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
        return await Task.FromResult(listaFornecedores.Where(h => h.contacto.ToLower().Contains(searchText.ToLower()) || h.nome.ToLower().Contains(searchText.ToLower()) || h.nomevendedor.ToString().Contains(searchText.ToLower())).ToList());
    }

    private async Task<IEnumerable<TipoProduto>> ProcurarTipoProdutos(string searchText)
    {
        return await Task.FromResult(listaTipoProdutos.Where(h => h.codigo.ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower())).ToList());
    }

    private async Task<IEnumerable<CabecalhoProdutos>> ProcurarProdutos(string searchText)
    {
        return await Task.FromResult(listaCabecalhoProduto.Where(h => h.descricao.ToLower().Contains(searchText.ToLower()) || h.idproduto.Equals(searchText.ToLower())).ToList());
    }

    private async Task<IEnumerable<Colaboradores>> ProcurarColaboradores(string searchText)
    {
        return await Task.FromResult(colaboradores.Where(h => h.codigo.ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower())).ToList());
    }

    private async Task<IEnumerable<TipodeCompra>> ProcurarCompra(string searchText)
    {
        return await Task.FromResult(LTDC.Where(h => h.idtipocompra.ToString().ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower())).ToList());
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
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
