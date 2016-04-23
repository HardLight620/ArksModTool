INCLUDE <ASMInclude.asm>

public CameraControlMainHook
public CameraControlMainHook_End
public CameraControlMainHook_Bindings

.DATA

CameraControlMainHook_Bindings	DWORD		0
bind0							DWORD		b0+1

.CODE

CameraControlMainHook:
b0:	call NO_SYMBOL
CameraControlMainHook_End:

END