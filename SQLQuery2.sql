select * from rol
/*
insert into rol (Descripcion)
values('EMPLEADO')
*/
select * from USUARIO
insert into USUARIO(Documento,NombreCompleto,Correo,Clave,IdRol,Estado)
values

('202020','EMPLEADO','@GMAIL','456',2,1)


select * from rol

insert into rol (Descripcion)
values('ADMINISTRADOR')

select * from PERMISO

select p.IdRol, p.NombreMenu from PERMISO p
inner join ROL r on r.IdRol = p.IdRol
inner join USUARIO  u on u.IdRol = r.IdRol
where u.IdUsuario = 1

/*
insert into PERMISO(idRol, NombreMenu) values
(1, 'IMbtnUsuarios'),
(1, 'IMbtnMantenimiento'),
(1, 'IMbtnVentas'),
(1, 'IMbtnCompras'),
(1, 'IMbtnProveedores'),
(1, 'IMbtnClientes'),
(1, 'IMbtnReportes'),
(1, 'IMbtnAcercaDe')

insert into PERMISO(idRol, NombreMenu) values
(2, 'IMbtnVentas'),
(2, 'IMbtnCompras'),
(2, 'IMbtnProveedores'),
(2, 'IMbtnClientes'),
(2, 'IMbtnAcercaDe')
*/