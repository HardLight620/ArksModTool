INCLUDE <ASMInclude.asm>

public ToggleLODHook
public ToggleLODHook_End
public ToggleLODHook_Bindings

.DATA

ToggleLODHook_Bindings	DWORD		0
bind0					DWORD		b0+1

.CODE

ToggleLODHook:
	nopx 3
b0:	jmp NO_SYMBOL
ToggleLODHook_End:

END