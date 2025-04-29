using Iyzipay;
using Iyzipay.Model;
using Iyzipay.Request;
using Microsoft.AspNetCore.Mvc;
using StoreApp.Data.Abstract;
using StoreApp.Data.Concrete;
using StoreApp.Web.Models;
using System.Threading.Tasks;

public class OrderController : Controller
{
    private Cart cart;
    private IOrderRepository _orderRepository;
    public OrderController(Cart cartService, IOrderRepository orderRepository)
    {
        cart = cartService;
        _orderRepository = orderRepository;
    }

    public IActionResult Checkout()
    {
        return View(new OrderModel() { Cart = cart });
    }


    
   
    
}