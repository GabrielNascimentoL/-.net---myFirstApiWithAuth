using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using myFirstAPIwithAuth.Models;

namespace myFirstAPIwithAuth.Data;

public class AppDbContext(DbContextOptions options) : IdentityDbContext<User>(options);