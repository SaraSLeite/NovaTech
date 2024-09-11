CREATE DATABASE NovaTech;
USE NovaTech;


CREATE TABLE produtos (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(255) NOT NULL,
    categoria VARCHAR(100) NOT NULL,
    descricao TEXT,
    preco DECIMAL(10, 2) NOT NULL,
    quantidade INT NOT NULL,
    cor VARCHAR(50) 
);


INSERT INTO produtos (nome, categoria, descricao, preco, quantidade, cor) VALUES
('iPhone 15', 'Smartphone', 'Último modelo da Apple com tela Super Retina XDR e chip A17 Bionic.', 999.99, 50, 'Azul'),
('Samsung Galaxy S24', 'Smartphone', 'Smartphone com tela Dynamic AMOLED 2X e câmera de 108 MP.', 899.99, 45, 'Azul'),
('Google Pixel 8', 'Smartphone', 'Telefone com câmeras avançadas e o novo processador Google Tensor.', 799.99, 40, 'Azul'),
('MacBook Air M2', 'Notebook', 'Notebook ultrafino da Apple com chip M2 e tela Retina.', 1199.99, 30, 'Prata'),
('Dell XPS 13', 'Notebook', 'Laptop compacto com tela InfinityEdge e processador Intel Core i7.', 1299.99, 25, 'Prata'),
('Sony WH-1000XM5', 'Fone de Ouvido', 'Fones de ouvido com cancelamento de ruído ativo e qualidade de som premium.', 349.99, 20, 'Preto'),
('Bose QuietComfort 45', 'Fone de Ouvido', 'Fones de ouvido com excelente cancelamento de ruído e conforto prolongado.', 329.99, 15, 'Preto'),
('Canon EOS R5', 'Câmera', 'Câmera mirrorless com resolução de 45 MP e capacidade de gravação em 8K.', 3899.99, 10, 'Vermelho'),
('Sony Bravia XR', 'TV', 'Smart TV 4K com tecnologia OLED e sistema de som integrado.', 2499.99, 20, 'Cinza'),
('Samsung QLED 8K', 'TV', 'Televisor 8K QLED com qualidade de imagem superior e recursos inteligentes.', 3499.99, 15, 'Cinza');
