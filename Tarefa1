        using (var context = new ApplicationContext())
        {

            var client = new Cliente()
            {
                CPF = "xxxxxxxxxxx",
                Nome = "Nome_Qualquer",
                Email = "XXYY@gmail.com",
                Senha = XXYY
            };
            context.Clientes.Add(client);
            context.SaveChanges();

            var fat = new Faturamento()
            {
                Valor = 15,
                MetodoPagamento = "Crédito",
                ClienteId = client.Id
            };

            var porta = new Estacionamento()
            {
                HoraEntrada = DateTime.Now,
                HoraSaida = DateTime.Now.AddHours(3),
            };
            context.Portas.Add(porta);
            context.SaveChanges();

            var tag = new Tag()
            {
                portaID = porta.Porta,
            };
            context.Tags.Add(tag);
            context.SaveChanges();

            var veiculo = new Veiculo()
            {
                Placa = "XXX123",
                Modelo = "Modelo_Qualquer",
                ClienteId = client.Id,
                Tag_id = tag.NumTag
            };
            context.Veiculos.Add(veiculo);
            context.SaveChanges();


            context.Faturamentos.Add(fat);
            context.SaveChanges();
        }
    }
