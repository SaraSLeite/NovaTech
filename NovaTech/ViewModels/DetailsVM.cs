using NovaTech.Models;

namespace NovaTech.ViewModels;

public class DetailsVM
{
    public Produtos Anterior { get; set; }
    public Produtos Atual { get; set; }
    public Produtos Proximo { get; set; }
}
