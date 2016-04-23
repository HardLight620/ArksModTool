INCLUDE <ASMInclude.asm>

public DisableECodeMapChange
public DisableECodeMapChange_End
public DisableECodeMapChange_Bindings

.DATA

DisableECodeMapChange_Bindings	DWORD		0

.CODE

DisableECodeMapChange:
	jmp ($+2) + 0C
DisableECodeMapChange_End:

END