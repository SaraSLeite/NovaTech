using NovaTech.Models;

namespace NovaTech.ViewModels;

public class DetailsVM
{
    public Produto Anterior { get; set; }
    public Produto Atual { get; set; }
    public Produto Proximo { get; set; }
}
