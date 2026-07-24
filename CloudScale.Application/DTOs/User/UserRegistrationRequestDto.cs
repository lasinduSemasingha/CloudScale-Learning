namespace CloudScale.Application.DTOs.User;
public record UserRegistrationRequestDto
(
    string Email,
    string PasswordHash,
    string DisplayName
);