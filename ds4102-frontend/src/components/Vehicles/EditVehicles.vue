<template>
    <section> 
        <h2 class="spacingTop">Vehicle Editing</h2>
        <section id="inputSection">
            <section class="container-lg">
                <section class="row justify-content-center">
                    <section class="col-lg-6">
                            <label for="id" class="form-label">Id</label>
                            <input v-model="vehicleId" type="text" class="form-control" id="id" placeholder="Type in ID and press 'Get'"/>
                            <input @click="getVehicle" type="button" value="Get" class="btn btn-primary"> <br>
                            
                            <label for="name" class="form-label">VehicleType</label>
                            <input v-model="vehicleType" type="text" class="form-control"/>

                            <label for="location" class="form-label">Number of seats</label>
                            <input v-model="numberOfSeats" type="text" class="form-control"/>

                            <input @click="changeVehicle" type="button" value="Save" class="btn btn-success">
                            <input @click="postVehicle" type="button" value="Add" class="btn btn-primary">
                            <input @click="deleteVehicle" type="button" value="Delete" class="btn btn-danger">
                    </section> 
                </section>
            </section>
        </section>
    </section>
</template>

<script>
import vehicleService from "../../services/vehicleService.js"
import {reactive, toRefs} from 'vue'


export default {
  setup(){
       
       const vehicleForm = reactive({
            vehicleId: "",
            vehicleType: "",
            numberOfSeats: 1,
        });

        const getVehicle = async () => {
            const vehicle = await vehicleService.getById(vehicleForm.vehicleId);
            vehicleForm.vehicleType = vehicle.vehicleType;
            vehicleForm.numberOfSeats = vehicle.numberOfSeats;         
        }

        const changeVehicle = async () => {

            const editedVehicle = {
                vehicleId: parseInt( vehicleForm.vehicleId ),
                vehicleType: vehicleForm.vehicleType,
                numberOfSeats: parseInt( vehicleForm.numberOfSeats)
            }

            vehicleService.putVehicle( editedVehicle );
                
        }

        const postVehicle = () => {

            const newVehicle = {
                vehicleType: vehicleForm.vehicleType,
                numberOfSeats: parseInt( vehicleForm.numberOfSeats)
            };

            vehicleService.postVehicles ( newVehicle );
        }

        const deleteVehicle = async () => {
            
            vehicleService.deleteVehicle(vehicleForm.vehicleId);
            

        }

        
        return{
          getVehicle,
          deleteVehicle,
          changeVehicle,
          postVehicle,
          ...toRefs( vehicleForm)
      }
    },
    
    components: { 
    },
  
}
</script>