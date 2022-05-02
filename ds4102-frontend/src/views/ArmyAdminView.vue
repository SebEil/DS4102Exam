<template>
    <section id="inputSection">
        <section class="container-lg">
            <section class="text-center">
                <h2>Army Admin Page</h2>
            </section>
            <section class="row justify-content-center">
                <section class="col-lg-3">
                    <form>
                        <section class="input-group">
                            <label for="id" class="form-label">Id</label>
                            <input v-model="missionId" type="text" class="form-control" id="id" placeholder="Type in ID and press 'Get'"/>
                            <input @click="getMission" type="button" value="Get" class="btn btn-primary">
                        </section>
                        
                        <section class="input-group">
                            <label for="name" class="form-label">MissionName</label>
                            <input v-model="missionName" type="text" class="form-control"/>
                        </section>

                        <section class="input-group">
                            <label for="location" class="form-label">Location</label>
                            <input v-model="missionLocation" type="text" class="form-control"/>
                        </section>

                        <section class="input-group">
                            <label for="deployed" class="form-label">Soldiers deployed</label>
                            <input v-model="soldiersDeployed" type="text" class="form-control">
                        </section>

                        <input @click="changeMission" type="button" value="Save" class="btn btn-success">
                        <input @click="postMission" type="button" value="Add" class="btn btn-primary">
                        <input @click="deleteMission" type="button" value="Delete" class="btn btn-danger">
                    </form>
                </section> 
            </section>
        </section>
    </section>
    <missions-list></missions-list>
</template>


<script>
import MissionsList from "../components/missions/MissionsList.vue"
import missionService from "../services/missionService.js"
import {reactive, toRefs} from 'vue'


export default {
  setup(){
       
       const missionForm = reactive({
            missionId: "",
            missionName: "",
            missionLocation: "",
            soldiersDeployed: 1
        });

        const missionFormNew = reactive({
            missionName: "",
            missionLocation: "",
            soldiersDeployed: 1
        });

        const getMission = async () => {
            const mission = await missionService.getById(missionForm.missionId);
            missionForm.missionName = mission.missionName;
            missionForm.missionLocation = mission.missionLocation;
            missionForm.soldiersDeployed = mission.soldiersDeployed;           
        }

        const changeMission = async () => {

            const editedMission = {
                missionId: parseInt( missionForm.missionId ),
                missionName: missionForm.missionName,
                missionLocation: missionForm.missionLocation,
                soldiersDeployed: parseInt( missionForm.soldiersDeployed)
            }

            missionService.putMission( editedMission );
        }

        const postMission = () => {

            const newMission = {
                missionId: missionFormNew.missionId,
                missionName: missionFormNew.missionName,
                missionLocation: missionFormNew.missionLocation,
                soldiersDeployed: missionFormNew.soldiersDeployed
            };

            missionService.postMission ( newMission );
        }

        

      return{
          getMission,
          changeMission,
          postMission,
          ...toRefs( missionForm )
      }
  },
  components: { 
      MissionsList 
    },
  
}
</script>

<style scoped>

    *{
        color: #FFF;
    }

    h2{
        margin-top: -30px;
        padding-top: 20px;
    }

    input{
        color: black;
        margin: 5px;
    }

    label{
        margin: 15px 5px;
    }

</style>