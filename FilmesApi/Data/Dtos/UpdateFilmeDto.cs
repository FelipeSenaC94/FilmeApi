using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class UpdateFilmeDto
{

    [Required(ErrorMessage = "O título é obrigatório")]
    public string Titulo { get; set; }



    [Required(ErrorMessage = "O gênero é obrigatório")]
    [StringLength(100, ErrorMessage = "O numero max de caracteres é 100")]
    public string Genero { get; set; }


    [Required(ErrorMessage = "A duração é obrigatória")]
    [Range(70, 600, ErrorMessage = "A duração precisa ser entre 70 e 600 minutos")]
    public int Duracao { get; set; }
}
