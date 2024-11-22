using Microsoft.AspNetCore.Mvc;

namespace Ferent_Ioan_Lab1.Controllers
{
    public class Hello : Controller
    {
        public string Index()
        {
            return "Bine ai venit în aplicația noastră!";
        }

        public string SalutUtilizator()
        {
            return "Salut, utilizatorule!";
        }

        public string MesajPersonalizat(string nume)
        {
            return $"Salut, {nume}! Sperăm că ai o zi minunată!";
        }
    }
}
