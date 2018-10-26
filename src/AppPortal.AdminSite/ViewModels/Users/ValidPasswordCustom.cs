using System;
using System.ComponentModel.DataAnnotations;

namespace AppPortal.AdminSite.ViewModels.Users
{
    public class ValidPasswordCustom : ValidationAttribute
    {
        protected override ValidationResult
                IsValid(object value, ValidationContext validationContext)
        {
            var model = (AccountViewModel)validationContext.ObjectInstance;
            string _passViewModel = Convert.ToString(value);
            string _passJoin = Convert.ToString(model.Password);

            if (string.IsNullOrEmpty(_passViewModel) && string.IsNullOrEmpty(model.AccountId))
            {
                if (_passViewModel.Length > 100 || _passViewModel.Length < 5)
                {
                    return new ValidationResult
                        ("Mật khẩu phải ít nhất 5 và không vượt quá 100 kí tự độ dài.");
                }
                return new ValidationResult
                        ("Mật khẩu không được để trống.");
            }
            else
            {
                return ValidationResult.Success;
            }
        }
    }

    public class ValidPasswordConfirmCustom : ValidationAttribute
    {
        protected override ValidationResult
                IsValid(object value, ValidationContext validationContext)
        {
            var model = (AccountViewModel)validationContext.ObjectInstance;
            string _passViewModel = Convert.ToString(value);
            string _passJoin = Convert.ToString(model.Password);

            if (!string.Equals(_passViewModel, _passJoin))
            {
                return new ValidationResult
                        ("Mật khẩu xác nhận không khớp.");
            }
            else
            {
                return ValidationResult.Success;
            }
        }
    }
}
