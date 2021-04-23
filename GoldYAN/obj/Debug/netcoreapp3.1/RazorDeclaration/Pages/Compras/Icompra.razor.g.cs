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
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Controller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Compras\Icompra.razor"
using GoldYAN.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Compras\Icompra.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/icompra")]
    public partial class Icompra : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 229 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Compras\Icompra.razor"
       

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







    // Declaration of needed lists
    List<Unidades> listaUnidades = new List<Unidades>();
    List<ClassificacaoProdutos> listaClassificacaoProdutos = new List<ClassificacaoProdutos>();
    List<Fornecedores> listaFornecedores = new List<Fornecedores>();
    List<TipoDePeca> listaTipoDePecas = new List<TipoDePeca>();
    List<TipoProduto> listaTipoProdutos = new List<TipoProduto>();
    List<Colaboradores> colaboradores = new List<Colaboradores>();
    List<CabecalhoProdutos> listaCabecalhoProduto = new List<CabecalhoProdutos>();








    //For input values
    List<Data.CabecalhoProdutos> LCP = new List<CabecalhoProdutos>();
    List<Data.Compras> LC = new List<Data.Compras>();








    // General variables
    bool Readonly = false;
    int i;
    string formadepesquisa;
    bool ProdutoNovo = true;
    public string Filter { get; set; }







    // Function that always runs when someone enter in the page
    protected override async Task OnInitializedAsync()
    {

        // Values that the program search in database
        listaFornecedores = FC.GetAll();
        listaClassificacaoProdutos = CPC.GetAll();
        listaUnidades = UC.GetAll();
        listaTipoDePecas = TPC.GetAll();
        listaTipoProdutos = TPRC.GetAll();
        listaCabecalhoProduto = CAPC.GetAll();

        // Initial Values in CFabrico Page
        var res = CAPC.GetMaxID();
        JsRuntime.InvokeVoidAsync("console.log", res);
        CCP.idproduto = 8;
        CCompra.datacriacao = DateTime.Now.ToShortDateString();

    }






    public bool IsVisible(CabecalhoProdutos produtos)
    {
        if (string.IsNullOrEmpty(Filter))
            return true;

        if (produtos.idproduto.Equals(Filter) || produtos.descricao.ToString().Contains(Filter) || produtos.apontamentos.ToString().Contains(Filter))
            return true;

        return false;
    }







    public async Task AdicionarComposto()
    {
        if(ProdutoNovo)
        {
            i++;
            CCP.idclassificação = ecp.IDClassificacao;
            CCP.idtipodeproduto = dtp.idtipoproduto;
            CCP.idtipodepeca = dtdp.idpeca;
            Compra.quantidade =  CCP.stock.Value;
            CCP.stocktotal = CCP.stock + CCP.updatestock;
            CCP.stock = CCP.stocktotal;
            Compra.idproduto = CCP.idproduto;
            Compra.linha = i;
            Compra.preco = CCP.preco.Value;
            
            LCP.Add(CCP);
            LC.Add(Compra);

        }
        else
        {
            i++;
            CCP.idclassificação = ecp.IDClassificacao;
            CCP.idtipodeproduto = dtp.idtipoproduto;
            CCP.idtipodepeca = dtdp.idpeca;
            Compra.quantidade = CCP.stock.Value;
            CCP.stocktotal = CCP.stock + CCP.updatestock;
            CCP.stock = CCP.stocktotal;
            Compra.idproduto = CCP.idproduto;
            Compra.linha = i;
            Compra.preco = CCP.preco.Value;
            LCP.Add(CCP);
            LC.Add(Compra);

        }
    }







    // Function that creates the product if new and creates also the cabecalhofabrico and fabrico
    public async Task CriarProduto()
    {
        if (LCP.Count != 0)
        {

            if (CCompra.produtonovo)
            {

                CCompra.idfornecedor = fornecedores.idfornecedor;

                var resultado = CComprasC.Post(CCompra);

                if(LCP.Count > 1)
                {
                    for (int i = 0; i < LCP.Count; i++)
                    {
                        CAPC.Post(LCP[i]);

                        LC[i].idcompra = resultado.idcompra;

                        ComprasC.Post(LC[i]);
                    }

                }
                else
                {
                    CAPC.Post(LCP[0]);

                    LC[0].idcompra = resultado.idcompra;

                    ComprasC.Post(LC[0]);
                }

            }
            else
            {

                var resultado = CComprasC.Post(CCompra);

                if (LCP.Count > 1)
                {
                    for (int i = 0; i < LCP.Count; i++)
                    {
                        CAPC.Put(LCP[i].idproduto,LCP[i]);

                        LC[i].idcompra = resultado.idcompra;

                        ComprasC.Post(LC[i]);
                    }

                }
                else
                {
                    CAPC.Put(LCP[0].idproduto, LCP[0]);

                    LC[0].idcompra = resultado.idcompra;

                    ComprasC.Post(LC[0]);
                }


            }





        }
        else
        {
            await js.InvokeVoidAsync("alert", "Impossível criar a encomenda, por favor, insira bem os dados da encomenda!");
        }
    }








    // Function that does the selecting in the selected buttons
    public async Task CriarProdutoNovo()
    {
        CCP = new CabecalhoProdutos();
        ProdutoNovo = true;
        CCP.produtonovo = true;
        CCompra.produtonovo = true;
    }







    // Function that does the selecting in the selected buttons
    public async Task UsarProdutoExistente()
    {
        CCP = new CabecalhoProdutos();
        ProdutoNovo = false;
        CCP.produtonovo = false;
        CCompra.produtonovo = false;
    }






    public async Task EditarComposto(int linha)
    {
    }





    public async Task ApagarComposto(int linha)
    {
        //LCP.Remove(listaProdutos[linha - 1]);
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


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
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
