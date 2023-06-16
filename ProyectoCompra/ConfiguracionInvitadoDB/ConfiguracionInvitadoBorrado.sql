-- ¡ OJO ! IMPORTANTE
-- SCRIPT PARA PROGRAMAR EL BORRADO AUTOMÁTICO DE LOS USUARIOS INVITADOS 

USE msdb; 
GO
EXEC dbo.sp_add_job
    @job_name = N'BorrarUsuarioInvitado',
    @enabled = 1;
GO
EXEC dbo.sp_add_jobstep
    @job_name = N'BorrarUsuarioInvitado',
    @step_name = N'BorrarRegistrosExpirados',
    @subsystem = N'TSQL',
    @command = N'DELETE FROM Usuario u
				 INNER JOIN Detalle_Usuario d ON (u.Id_Usuario = d.Id_Usuario)
				 WHERE d.Fecha_Ultima_Modificacion = GETDATE() AND
				 u.Invitado = 1';
GO
EXEC dbo.sp_add_schedule
    @schedule_name = N'ProgramacionBorradoUsuariosInvitados',
    @freq_type = 4,
    @freq_interval = 1,
    @active_start_time = 010000;
GO
EXEC dbo.sp_attach_schedule
    @job_name = N'BorrarUsuarioInvitado',
    @schedule_name = N'ProgramacionBorradoUsuariosInvitados';
GO
EXEC dbo.sp_add_jobserver
    @job_name = N'BorrarUsuarioInvitado';
GO