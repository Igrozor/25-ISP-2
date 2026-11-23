.data
    a dd 10
    b dd 15
    X dd ?

.code
main proc
    mov eax, a
    cmp eax, b
    je do_if      
    jg end_if       
    mov eax, a    
    mov ebx, a    
    imul ebx      
    imul ebx        
    sub eax, b      
    mov edx, 0     
    cmp eax, 0     
    jge div_less    
    mov edx, -1     
div_less:
    mov ebx, b  
    idiv ebx       

    mov X, eax
    ret

do_if:              
    mov eax, 43
    mov X, eax
    ret

end_if:          
    mov eax, b      

    mov edx, 0      
    cmp eax, 0     
    jge div_greater 
    mov edx, -1    
div_greater:
    mov ebx, a      
    idiv ebx       
    sub eax, 7      ;

    mov X, eax
    ret
main endp
end