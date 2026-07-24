namespace CloudScale.Application.DTOs.User;
public record UserLoginRequestDto
(
    string Email,
    string Password
);