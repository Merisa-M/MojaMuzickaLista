import { Component, OnInit,Input } from '@angular/core';
import {NgbModal, ModalDismissReasons, NgbModalOptions} from '@ng-bootstrap/ng-bootstrap';
import { SharedService } from '../shared.service';
import { ToastrService } from 'ngx-toastr';
import { NgxSpinnerService } from "ngx-spinner";
import { first } from 'rxjs/operators';
@Component({
  selector: 'app-pjesma',
  templateUrl: './pjesma.component.html',
  styleUrls: ['./pjesma.component.css']
})
export class PjesmaComponent implements OnInit {
 
  constructor(private SharedService:  SharedService,  private modalService:NgbModal,
    private toastr: ToastrService,
    private spinner: NgxSpinnerService) { }
    
    ngOnInit(): void {
    this.GetAll();
    this.GetKategorije();
  }
  PjesmeList:any=[];
  isDtInitialized:boolean = false;
  kategorije:any[]=[];
  pjesma:any={};
  closeResult: string;
  modalOptions:NgbModalOptions;
  kateogorije:any[]=[];


  open(content:any) {
    this.PjesmeList={};
    this.modalService.open(content, this.modalOptions).result.then((result) => {
      this.closeResult = `Closed with: ${result}`;
    }, (reason) => {
      this.closeResult = `Dismissed ${this.getDismissReason(reason)}`;
    });
  }
  private getDismissReason(reason: any): string {
    if (reason === ModalDismissReasons.ESC) {
      return 'by pressing ESC';
    } else if (reason === ModalDismissReasons.BACKDROP_CLICK) {
      return 'by clicking on a backdrop';
    } else {
      return  `with: ${reason}`;
    }
  }
  GetAll(){
    this.SharedService.getPjesmeList().subscribe(data=>{
      this.PjesmeList=data;
    });
  }
  GetKategorije(){
    this.SharedService.getKategorije().subscribe(data=>{
      this.kategorije=data;
    });
  }
  deletePut(item:any){
    if(confirm('Are you sure??')){
      this.SharedService.delete(item.pjesmaID).subscribe(data=>{
        alert(data.toString());
        this.GetAll();
      })
    }
  }
  openEditModal(content:any,podaci:any) {
    this.pjesma=podaci;
     this.modalService.open(content, this.modalOptions).result.then((result) => {
      this.closeResult = `Closed with: ${result}`;
    }, (reason) => {
      this.closeResult = `Dismissed ${this.getDismissReason(reason)}`;
    });
  }
  //save() {


    //var d1 = new Date(this.pjesma.datumEditovanja);
    

    //this.predmet.datumPocetka=d1.toDateString();
    

//     if(this.pjesma.pjesmaID){

//       this.spinner.show();

      
//       this.SharedService
//           .update("Pjesma/"+ this.pjesma.pjesmaID, this.pjesma)
//           .pipe(first())
//           .subscribe(
//             (data) => {
//               this.GetAll();
//               this.pjesma = {};

//              this.spinner.hide();
//               this.modalService.dismissAll();
//                this.toastr.success("Data is successfully saved!", "Success!");
//             },
//             (error) => {
//                this.spinner.hide();
//                this.toastr.error("Server error, please ", "Error!");
//             }
//           );


//     }


// else{
   
//   this.spinner.show();

//     this.SharedService
//         .save("Pjesma", this.pjesma)
//         .pipe(first())
//         .subscribe(
//           (data) => {
//             this.GetAll();
//             this.pjesma = {};

//            this.spinner.hide();
//             this.modalService.dismissAll();
//              this.toastr.success("Data is successfully saved!", "Success!");
//           },
//           (error) => {
//              this.spinner.hide();
//              this.toastr.error("Server error, please ", "Error!");
//           }
//         );
//     }
  
//   }

}