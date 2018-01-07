<<<<<<< HEAD
program vtk_read
use vtk_write
use precision
=======
!---------------------------------------------------------------------
! Mesh Generation Framework                    
!---------------------------------------------------------------------
!
!> MODULE: Name of Module/Program
!
!> @author
!> ADD AUTHOR NAME
!
! DESCRIPTION: 
!> Description of Module/Program
!
!---------------------------------------------------------------------
!


program vtk_read
use vtk_write
>>>>>>> 83b0ace25686c943fe39b611d7a5336787490d79
  implicit none

  call timestamp ( )
  write ( *, '(a)' ) ' '
  write ( *, '(a)' ) 'VTK_IO_PRB'
  write ( *, '(a)' ) '  FORTRAN90 version'
  write ( *, '(a)' ) '  Test the VTK_IO library.'

  call test01 ( )
!
!  Terminate.
!
  write ( *, '(a)' ) ' '
  write ( *, '(a)' ) 'VTK_IO_PRB'
  write ( *, '(a)' ) '  Normal end of execution.'
  write ( *, '(a)' ) ' '
  call timestamp ( ) !timestamp to mention the time of execution

  stop

contains
subroutine test01 ( )

  implicit none

  character ( len = 80 ) output_filename
  character ( len = 80 ) title

<<<<<<< HEAD
  real    (rk)          :: myLine
  integer  (ik)         :: i, j, myRow,myColumn,node_num,element_num,element_order,output_unit
  character(len=30) :: myFileName1
  real(rk),allocatable ::n(:),xyz(:,:),x(:),y(:),z(:),u(:),uvw(:,:),v(:),w(:),p(:)
  integer(ik),allocatable :: element_node(:,:)
=======
  real              :: myLine
  integer           :: i, j, myRow,myColumn,node_num,element_num,element_order,output_unit
  character(len=30) :: myFileName1
  real(8),allocatable ::n(:),xyz(:,:),x(:),y(:),z(:),u(:),uvw(:,:),v(:),w(:),p(:)
  integer,allocatable :: element_node(:,:)
>>>>>>> 83b0ace25686c943fe39b611d7a5336787490d79

  write ( *, '(a)' ) ' '
  write ( *, '(a)' ) 'TEST01'
  write ( *, '(a)' ) '  VTK_PUVW_WRITE writes 3d fluid data, pressure and '
  write ( *, '(a)' ) '  velocity, to a VTK file.'

  myFileName1='raw_mesh.dat'

<<<<<<< HEAD
  open(98, file=myFileName1)
  write(*,*)'open data file'
  read(98, *) node_num,element_num,element_order
=======
  open(99, file=myFileName1)
  write(*,*)'open data file'
  read(99, *) node_num,element_num,element_order
>>>>>>> 83b0ace25686c943fe39b611d7a5336787490d79

  allocate(n(node_num))
  allocate(xyz(3,node_num))
  allocate(x(node_num))
  allocate(y(node_num))
  allocate(z(node_num))
  allocate(uvw(3,node_num))
  allocate(u(node_num))
  allocate(v(node_num))
  allocate(w(node_num))
  allocate(p(node_num))
  allocate(element_node(element_num,element_order))

  do i=1,node_num
<<<<<<< HEAD
    read(98,*) x(i),y(i),z(i),n(i),u(i),v(i),w(i),p(i)
=======
    read(99,*) x(i),y(i),z(i),n(i),u(i),v(i),w(i),p(i)
>>>>>>> 83b0ace25686c943fe39b611d7a5336787490d79
  enddo

print*,element_num
print*,element_order

  element_node=reshape(n(:),(/element_num,element_order/))

<<<<<<< HEAD
  close(98)



  output_filename = 'vtkoutput.vtk'
  title ='vtkoutput'
=======
  close(99)



  output_filename = 'puvw_data.vtk'
  title = 'Sample data for VTK_PUVW_WRITE.'
>>>>>>> 83b0ace25686c943fe39b611d7a5336787490d79


        xyz(1,:) = x(:)
        xyz(2,:) = y(:)
        xyz(3,:) = z(:)
        uvw(1,:) = u(:)
        uvw(2,:) = v(:)
        uvw(3,:) = w(:)


  call get_unit ( output_unit )!to avoid 5,6,and9 as the unit number //output_unit is independent number for file creation

<<<<<<< HEAD
!  open ( unit = output_unit, file = output_filename, status = 'replace' )

  call vtk_data_write ( output_unit, title, node_num, element_num, &
=======
  open ( unit = output_unit, file = output_filename, status = 'replace' )

  call vtk_puvw_write ( output_unit, title, node_num, element_num, &
>>>>>>> 83b0ace25686c943fe39b611d7a5336787490d79
    element_order, xyz, element_node, p, uvw)! 

  close (  unit = output_unit )

  write ( *, '(a)' ) ' '
  write ( *, '(a)' ) '  VTK_PUVW_WRITE created the file.'

  return
end
end
