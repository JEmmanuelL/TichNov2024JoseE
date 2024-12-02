CREATE DATABASE EjerciciosTich;

use EjerciciosTich;

GO

CREATE TABLE CursosInstructores (
id INT IDENTITY,
idCurso smallint,
idInstructor int,
fechaContratacion date NULL,
primary key (id)
);

CREATE TABLE AlumnosBaja (
id INT IDENTITY,
nombre varchar(60),
primerApellido varchar(50),
segundoApellido varchar(50) NULL,
fechaContratacion datetime NULL,
primary key (id)
);

------------------------------

CREATE TABLE Estados (
id INT,
nombre varchar(100),
primary key (id)
);

CREATE TABLE EstatusAlumnos (
id smallint,
Clave char(10),
nombre varchar(100),
primary key (id)
);

CREATE TABLE CatCursos (
id smallint IDENTITY,
clave varchar(15),
nombre varchar(50),
descripcion varchar(1000) NULL,
horas tinyint,
idPreRequisito smallint NULL,
activo bit,
primary key (id)
);


CREATE TABLE Cursos (
id smallint IDENTITY,
idCatCurso smallint NULL,
fechaInicio date NULL,
fechatermino date NULL,
activo bit NULL,
primary key (id)
);

CREATE TABLE Alumnos (
id int IDENTITY,
nombre varchar(60),
primerApellido varchar(50),
segundoApellido varchar(50) NULL,
correo varchar(80),
telefono nchar(10),
fechaNacimiento date,
curp char(18),
sueldo decimal(9,2) NULL,
idEstadoOrigen int,
idEstatus smallint,
primary key (id)
);

CREATE TABLE Instructores (
id smallint IDENTITY,
nombre varchar(60),
primerApellido varchar(50),
segundoApellido varchar(50) NULL,
correo varchar(80),
telefono nchar(10),
fechaNacimiento date,
rfc char(13),
curp char(18),
cuotaHora decimal(9,2) NULL,
activo bit,
primary key (id)
);



CREATE TABLE CursosAlumnos (
id int IDENTITY,
idCurso smallint,
idAlumno int,
fechaInscripcion date,
fechaBaja date NULL,
calificacion tinyint NULL,
primary key (id)
);

-----

ALTER TABLE Cursos ADD CONSTRAINT fK_CatCursos_Cursos_ID
FOREIGN KEY (idCatCurso) REFERENCES CatCursos(id) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE Cursos DROP CONSTRAINT fK_CatCursos_Cursos_ID;


EXEC sp_helpconstraint CursosInstructores;

ALTER TABLE Alumnos ADD CONSTRAINT fk_Alumnos_EstadoOri_ID
FOREIGN KEY (idEstadoOrigen) REFERENCES Estados(ID) ON DELETE CASCADE ON UPDATE CASCADE;


ALTER TABLE Alumnos ADD CONSTRAINT fk_Alumnos_Estatus_ID
FOREIGN KEY (idEstatus) REFERENCES EstatusAlumnos(ID) ON DELETE CASCADE ON UPDATE CASCADE;


ALTER TABLE CursosAlumnos ADD CONSTRAINT fk_CursoAlumn_Curso
FOREIGN KEY (idCurso) REFERENCES Cursos(id) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE CursosAlumnos ADD CONSTRAINT fk_CursoAlumn_Alumno_ID
FOREIGN KEY (idAlumno) REFERENCES Alumnos(id) ON DELETE CASCADE ON UPDATE CASCADE;


ALTER TABLE CursosInstructores ADD CONSTRAINT fk_CursosInst_Cursos_ID
FOREIGN KEY (idCurso) REFERENCES Cursos(id) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE CursosInstructores ALTER COLUMN idInstructor smallint;

ALTER TABLE CursosInstructores ADD CONSTRAINT fk_CursosInst_Instructor_ID
FOREIGN KEY (idInstructor) REFERENCES Instructores(id) ON DELETE CASCADE ON UPDATE CASCADE;

