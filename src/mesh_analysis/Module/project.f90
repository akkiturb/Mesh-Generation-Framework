!!!!!  dont care about this file



module ratio
implicit none
contains

subroutine oreder
use READ_MAP 
type(cell), allocatable :: map1(:)
 
open(1, file=testfile)
read(1, *) node_num,element_xtot,element_ytot
allocate(map1((element_xtot-1)*(element_ytot-1)))
map1 = cells(node_num,element_xtot,element_ytot)
 do i=1, (element_xtot-1)*(element_ytot-1)        ! 5 x 21 = 105 cell elemnt
   
    P1 = map1(i)%P1
    P2 = map1(i)%P2
    P3 = map1(i)%P3
    P4 = map1(i)%P4

 end do

end subroutine order
!///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
!///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
subroutine test1 (maxi_as)

implicit none
real(8) :: p1x,p1y,p1z,p2x,p2y,p2z,p3x,p3y,p3z,p4x,p4y,p4z               ! 4 points P(x,y,z) 'the coordinate' of every cell
real(8) :: as, p1p2, p2p3, p3p4, p4p1                                    ! the 4  lengths of the cell
integer :: N
integer :: k,i                                                       
real(8), intent(out) :: maxi_as                                          ! the maximum as for all cells 
character(len=30) :: testfile

  testfile = 'testfile.dat'

open(1,file=testfile)
READ(1,*) N                                                                 ! import the number of cells from the data file    
maxi_as = 0        ! initial aspect ratio

do i=1, N

read (1,*) k,p1x,p1y,p1z,p2x,p2y,p2z,p3x,p3y,p3z,p4x,p4y,p4z                 ! import the data of points from the data file



p1p2=(((p2x-p1x)**2)+(((p2y-p1y)**2))+(((p2z-p1z)**2)))**0.5     !!!            
p2p3=(((p3x-p2x)**2)+(((p3y-p2y)**2))+(((p3z-p2z)**2)))**0.5     !!!!!     ! length magnitute for 2 points on the same axis
p3p4=(((p4x-p3x)**2)+(((p4y-p3y)**2))+(((p4z-p3z)**2)))**0.5     !!!!!
p4p1=(((p4x-p1x)**2)+(((p4y-p1y)**2))+(((p4z-p1z)**2)))**0.5     !!!


as=(max(p1p2,p2p3,p3p4,p4p1))/(min(p1p2,p2p3,p3p4,p4p1))                    ! the aspect ratio of every cell

maxi_as = max(maxi_as, as)                                                  ! Maximum aspect ration in the mesh

end do


 close(1)
end subroutine test1

end module ratio

