using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class CalculatorModel : PageModel
{
    [BindProperty]
    public double? Result { get; set; }

    public IActionResult OnPost(double arg1, double arg2, string operation)
    {
        // Check the operation requested (Add or Subtract)
        switch (operation)
        {
            case "Add":
                // Perform addition if the 'Add' button is clicked
                Result = arg1 + arg2;
                break;
            case "Subtract":
                // Perform subtraction if the 'Subtract' button is clicked
                Result = arg1 - arg2;
                break;
        }

        // Return the current Razor Page to update the displayed result
        return Page();
    }
}
